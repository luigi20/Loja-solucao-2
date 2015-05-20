using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Loja.Models
{
    public class ProdutoSimilar
    {

        private int idProdutoSimilar;
        private int produto;

        public ProdutoSimilar(int idProdutoSimilar,int produto)
        {
            this.produto = produto;
            this.idProdutoSimilar = idProdutoSimilar;
        }

        public int Produto
        {
            get { return produto; }
            set { produto = value; }
        }
        public int IdProdutoSimilar
        {
            get { return idProdutoSimilar; }
            set { idProdutoSimilar = value; }
        }
    }
}