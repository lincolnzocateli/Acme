using AcmeApp.Helpers;
using AcmeApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcmeApp.Application
{
    public class ProdutoAppService 
    {
        public IHandler<DomainNotification> Notifications;

        public ProdutoViewModel Adicionar(ProdutoViewModel produtoViewModel)
        {
            var _produto = ProdutoAdapter.ToDomainModel(produtoViewModel);

            if (!Notifications.HasNotifications())
            {
                var _adicionado = _produtoService.Adicionar(_produto);

                if (Commit())
                    produtoViewModel = TypeAdapter.Adapt<Produto, ProdutoViewModel>(_adicionado);
            }


            return produtoViewModel;
        }

    }
}
