using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcmeApp.Dominio
{
    public class ProdutoService
    {



        public ProdutoService()
        {


        }


        public Produto Adicionar(Produto produto)
        {

            produto = _produtoRepository.Adicionar(produto);

            return produto;
        }



    }
}
