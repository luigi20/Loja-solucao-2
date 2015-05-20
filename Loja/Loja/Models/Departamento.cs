﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Loja.Models
{
    public class Departamento
    {
        private int idDepartamento;
        private string nomeDepartamento;
        private string siglaDepartamento;
        private double comissaoDepartamento;

        public Departamento(int idDepartamento, string nomeDepartamento, string siglaDepartamento, double comissaoDepartamento)
        {
            this.idDepartamento = idDepartamento;
            this.nomeDepartamento = nomeDepartamento;
            this.siglaDepartamento = siglaDepartamento;
            this.comissaoDepartamento = comissaoDepartamento;
        }
        public Departamento()
        {

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

        public double ComissaoDepartamento
        {
            get { return comissaoDepartamento; }
            set { comissaoDepartamento = value; }
        }



    }
}