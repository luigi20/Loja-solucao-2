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

        public Produto()
        {

        }
        public  Produto (int idProduto, int departamentoProduto,string nomeProduto,double precoProduto,int quantidadeProduto )
        {
            this.idProduto = idProduto;
            this.nomeProduto = nomeProduto;
            this.precoProduto = precoProduto;
            this.quantidadeProduto = quantidadeProduto;
            this.departamentoProduto = departamentoProduto;

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
    }
}