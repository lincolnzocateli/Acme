using AcmeApp.Dominio;
using AcmeApp.ViewModel;

namespace AcmeApp.Application
{
    public class ProdutoAdapter
    {
        public static Produto ToDomainModel(ProdutoViewModel produtoViewModel)
        {
            var produto = new Produto
                (
                    produtoViewModel.ProdutoID,
                    produtoViewModel.Nome
                );

            produto.Atualizar
                (
                    produtoViewModel.Status
                );


            return produto;
        }
    }

}
