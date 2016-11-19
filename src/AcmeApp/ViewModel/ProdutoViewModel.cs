using System;
using System.Collections.Generic;

namespace AcmeApp.ViewModel
{
    public class ProdutoViewModel
    {

        public ProdutoViewModel()
        {
            this.ProdutoID = Guid.NewGuid();

        }
        public Guid ProdutoID { get; set; }
        
        public string Nome { get; set; }
        public string Status { get; set; }
        public virtual ICollection<MateriaPrimaViewModel> MateriaPrima { get; set; }
    }
}
