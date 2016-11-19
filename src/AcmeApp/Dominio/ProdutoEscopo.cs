using AcmeApp.Helpers;

namespace AcmeApp.Dominio
{
    public static class ProdutoEscopo 
    {
    
        public static bool DefinirNomeEscopoEhValido(this Produto produto, string nome)
        {

            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertLength(nome, Produto.minNome, Produto.maxNome, $"Tamanho do Nome do produto deve ser {Produto.minNome} e {Produto.maxNome}"),
                AssertionConcern.AssertNotNullOrEmpty(nome, "Nome do produto invalido.")
            );

        }

        public static bool DefinirStatusEscopoEhValido(this Produto produto, string status)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertTrue(status == "Ativo" || status == "Inativo", "Status Invalido.")
            );


        }
    }
}
