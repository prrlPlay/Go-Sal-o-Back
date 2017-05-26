using GoSalao.Salao.Fornecedor.Domain.TinyTypes;

namespace GoSalao.Salao.Fornecedor.Domain.Entity
{
    public class Fornecedor
    {
        public int FornecedorId { get; set; }

        public Documento Documento { get; set; }

        public Telefone Telefone { get; set; }

        public Email Email { get; set; }

        public Endereco Endereco { get; set; }

        public Fornecedor(Documento documento, Telefone telefone, Email email, Endereco endereco)
        {
            Documento = documento;
            Telefone = telefone;
            Email = email;
            Endereco = endereco;
        }

        public Fornecedor(int id, Documento documento, Telefone telefone, Email email, Endereco endereco)
        {
            FornecedorId = id;
            Documento = documento;
            Telefone = telefone;
            Email = email;
            Endereco = endereco;
        }
    }
}