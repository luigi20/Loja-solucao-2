﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Loja.Objeto.Models
{
    public class Venda
    {
        private int idVenda;
        private DateTime dataVenda;
        private double valorTotal;
        private List<Produto> listaProduto;
        
        public Venda(int idVenda,DateTime dataVenda, double valorTotal)
        {
            this.idVenda = idVenda;
            this.dataVenda = dataVenda;
            this.valorTotal = valorTotal;
            this.listaProduto = new List<Produto>();
        }

        public int IdVenda
        {
            get { return idVenda; }
            set { idVenda = value; }
        }
        public DateTime DataVenda
        {
            get { return dataVenda; }
            set { dataVenda = value; }
        }
        public double ValorTotal
        {
            get { return valorTotal; }
            set { valorTotal = value; }
        }

    }
}