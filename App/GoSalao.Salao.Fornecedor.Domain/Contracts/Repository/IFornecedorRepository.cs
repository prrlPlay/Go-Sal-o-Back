using System.Collections;

namespace GoSalao.Salao.Fornecedor.Domain.Contracts.Repository
{
    public interface IFornecedorRepository
    {
        ICollection ObterFornecedores(int take, int skip);

        ICollection ObterPorId(int id);

        void Adicionar();

        void Atualizar();

        void Remover();
    }
}