using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Loja.Objeto.Models
{
    public class Produto
    {
     
        private int idProduto;
        private int departamentoProduto;
        private string nomeProduto;
        private double precoProduto;
        private int quantidadeProduto;
        private int idProdutoSimilar;

        public Produto()
        {

        }
        public  Produto (int idProduto, int departamentoProduto,string nomeProduto,double precoProduto,int quantidadeProduto,int idProdutoSimilar )
        {
            this.idProduto = idProduto;
            this.nomeProduto = nomeProduto;
            this.precoProduto = precoProduto;
            this.quantidadeProduto = quantidadeProduto;
            this.departamentoProduto = departamentoProduto;
            this.idProdutoSimilar = idProdutoSimilar;
        }

        public int IdProduto
        {
            get { return idProduto; }
            set { idProduto = value; }
        }

        public int DepartamentoProduto
        {
            get { return departamentoProduto; }
            set { departamentoProduto = value; }

        }

        public string NomeProduto
        {
            get { return nomeProduto; }
            set { nomeProduto = value; }
        }

        public double PrecoProduto
        {
            get { return precoProduto; }
            set { precoProduto = value; }
        }

        public int QuantidadeProduto
        {
            get { return quantidadeProduto; }
            set { quantidadeProduto = value; }
        }

        public int IdProdutoSimilar
        {
            get { return idProdutoSimilar; }
            set { idProdutoSimilar = value; }
        }
    }
}