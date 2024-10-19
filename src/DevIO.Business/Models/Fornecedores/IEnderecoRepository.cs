using DevIO.Business.Core.Data;
using System;
using System.Threading.Tasks;

namespace DevIO.Business.Models.Fornecedores
{
    internal interface IEnderecoRepository : IRepository<Endereco>
    {
        Task<Endereco> ObterEderecoPorFornecedor(Guid fornecedorId);
    }
}
