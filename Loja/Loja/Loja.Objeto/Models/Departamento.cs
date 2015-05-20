﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Loja.Objeto.Models
{
    public class Departamento
    {
        
        private int idDepartamento;
        private string nomeDepartamento;
        private string siglaDepartamento;
        private double percComissaoDepartamento;
        private List<Produto> listaProdutoDepartamento;
        
        public Departamento()
        {

        }

        public Departamento(int idDepartamento,string nomeDepartamento,string siglaDepartamento,double percComissaoDepartamento)
        {
            this.idDepartamento = idDepartamento;
            this.nomeDepartamento = nomeDepartamento;
            this.siglaDepartamento = siglaDepartamento;
            this.percComissaoDepartamento = percComissaoDepartamento;
            this.listaProdutoDepartamento = new List<Produto>();
        }
        public int IdDepartamento
        {
            get { return idDepartamento; }
            set { idDepartamento = value; }
        }

        public string NomeDepartamento
        {
            get { return nomeDepartamento; }
            set { nomeDepartamento = value; }
        }

        public string SiglaDepartamento
        {
            get { return siglaDepartamento; }
            set { siglaDepartamento = value; }
        }

        public double PercComissaoDepartamento
        {
            get { return percComissaoDepartamento; }
            set { percComissaoDepartamento = value; }
        }



    }
}