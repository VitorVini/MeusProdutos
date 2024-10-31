namespace DevIO.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenomearPropriedadeComplemento : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Enderecos", "Complemento", c => c.String(maxLength: 250, unicode: false));
            DropColumn("dbo.Enderecos", "Complemnto");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Enderecos", "Complemnto", c => c.String(maxLength: 250, unicode: false));
            DropColumn("dbo.Enderecos", "Complemento");
        }
    }
}
