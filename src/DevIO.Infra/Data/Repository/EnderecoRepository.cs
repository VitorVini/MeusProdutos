﻿using DevIO.Business.Models.Fornecedores;
using DevIO.Infra.Data.Context;
using System;
using System.Threading.Tasks;

namespace DevIO.Infra.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(MeuDbContext context) : base(context) { }

        public async Task<Endereco> ObterEderecoPorFornecedor(Guid fornecedorId)
        {
            return await ObterPorId(fornecedorId); // Cardinalidade 1:1 PK e FK de Endereco e Fornecedor são identicas
        }
    }
}
