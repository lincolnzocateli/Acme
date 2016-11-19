using System;
using System.Collections.Generic;

namespace AcmeApp.Dominio

{
    public class Produto
    {
        protected Produto() { }
        
        public Produto(Guid produtoID, string nome)
        {
            this.ProdutoID = produtoID;
            this.DefineNome(nome);
        }
        public Guid ProdutoID { get; private set; }
        public string Nome { get; private set; }

        public string Status { get; private set; }
        // Indica relacionamento 1->n (1 produto, n materias primas)
        public virtual ICollection<MateriaPrima> MateriaPrima { get; private set; }

        public void DefineNome (string nome)
        {
            if (this.DefinirNomeEscopoEhValido(nome))
                this.Nome = nome;
        }

        public void DefinirStatus(string status)
        {
            if (this.DefinirStatusEscopoEhValido(status))
                this.Status = status;
        }

        public void Atualizar(string status)
        {
            this.DefinirStatus(status);
        }

        public const int minNome = 3;
        public const int maxNome = 150;
    }
}
