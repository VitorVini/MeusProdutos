using DevIO.Business.Core.Data;
using System;
using System.Threading.Tasks;

namespace DevIO.Business.Models.Fornecedores
{
    internal interface IFornecedorRepository : IRepository<Fornecedor>
    {
        Task<Fornecedor> ObterFornecedorEndereco(Guid id);
        Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id);
    }
}
