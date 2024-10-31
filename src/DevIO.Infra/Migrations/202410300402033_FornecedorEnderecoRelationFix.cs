public partial class FornecedorEnderecoRelationFix : DbMigration
{
    public override void Up()
    {
        DropForeignKey("dbo.Enderecos", "Fornecedor_Id", "dbo.Fornecedores");
        DropIndex("dbo.Enderecos", new[] { "Fornecedor_Id" });

        // Adiciona nova FK com relacionamento opcional
        AddColumn("dbo.Enderecos", "FornecedorId", c => c.Guid(nullable: true));
        CreateIndex("dbo.Enderecos", "FornecedorId");
        AddForeignKey("dbo.Enderecos", "FornecedorId", "dbo.Fornecedores", "Id");
    }

    public override void Down()
    {
        DropForeignKey("dbo.Enderecos", "FornecedorId", "dbo.Fornecedores");
        DropIndex("dbo.Enderecos", new[] { "FornecedorId" });

        DropColumn("dbo.Enderecos", "FornecedorId");

        // Restaura o índice e chave antiga
        AddColumn("dbo.Enderecos", "Fornecedor_Id", c => c.Guid(nullable: false));
        CreateIndex("dbo.Enderecos", "Fornecedor_Id");
        AddForeignKey("dbo.Enderecos", "Fornecedor_Id", "dbo.Fornecedores", "Id");
    }
}
