using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcmeApp.ViewModel
{
    public class MateriaPrimaViewModel
    {
        public MateriaPrimaViewModel()
        {
            this.MateriaPrimaID = Guid.NewGuid();
        }

        public Guid MateriaPrimaID { get; set; }
        public string nome { get; set; }
        public int estoqueMinimo { get; set; }
        public int estoqueAtual { get; set; }
        public int ProdutoID { get; set; }
    }
}
