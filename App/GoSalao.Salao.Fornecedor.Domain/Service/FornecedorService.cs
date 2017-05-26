using System;
using System.Collections;
using GoSalao.Salao.Fornecedor.Domain.Contracts.Service;
using GoSalao.Salao.Fornecedor.Domain.Contracts.Repository;

namespace GoSalao.Salao.Fornecedor.Domain.Service
{
    public class FornecedorService : IFornecedorService
    {
        private readonly IFornecedorRepository _repository;

        public FornecedorService(IFornecedorRepository repository)
        {
            _repository = repository;
        }

        public ICollection ObterFornecedores(int take, int skip)
        {
            return _repository.ObterFornecedores(take, skip);
        }

        public ICollection ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Adicionar(Entity.Fornecedor fornecedor)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Entity.Fornecedor fornecedor)
        {
            throw new NotImplementedException();
        }

        public void Remover(int id)
        {
            throw new NotImplementedException();
        }
    }
}