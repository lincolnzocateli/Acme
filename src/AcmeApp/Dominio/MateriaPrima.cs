using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcmeApp.Dominio
{
    public class MateriaPrima
    {
        public int MateriaPrimaID { get; set; }
        public string nome { get; set; }
        public int estoqueMinimo { get; set; }
        public int estoqueAtual { get; set; }
        public int ProdutoID { get; set; }
        public virtual Produto Produto { get; set; }

    }
}
