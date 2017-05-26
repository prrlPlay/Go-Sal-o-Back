using System.Collections;

namespace GoSalao.Salao.Fornecedor.Domain.Contracts.Service
{
    public interface IFornecedorService
    {
        ICollection ObterFornecedores(int take, int skip);

        ICollection ObterPorId(int id);

        void Adicionar(Entity.Fornecedor fornecedor);

        void Atualizar(Entity.Fornecedor fornecedor);

        void Remover(int id);
    }
}