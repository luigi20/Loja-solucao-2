using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Loja.Objeto.DAO;

namespace Loja.Objeto.Models
{
    public class RegistroVenda
    {
        private Departamento departamento;

        private int idVenda;

        private int idDepartamento;

        private int idProduto;

        private double comissao;

        private int idVendedor;

        public RegistroVenda(int idVenda, int idDepartamento, int idProduto, double comissao, int idVendedor)
        {
            this.idVenda = idVenda;
            this.idDepartamento = idDepartamento;
            this.idProduto = idProduto;
            this.comissao = comissao;
            this.idVendedor = idVendedor;
        }

        public Departamento Departamento
        {
            get
            {
                if (this.departamento == null)
                {
                    this.departamento = DepartamentoDAO.BuscarPorId(idDepartamento);
                }

                return departamento;
            }
            set { Departamento = value; }
        }
        public int IdVendedor
        {
            get { return idVendedor; }
            set { idVendedor = value; }
        }

        public int IdVenda
        {
            get { return idVenda; }
            set { idVenda = value; }
        }

        public int IdDepartamento
        {
            get
            {
                //                if (_departamento == null)
                //                  _departamento = Departamento.DAO.Obter(idDepartamento);

                //            return _departamento;

                return idDepartamento;
            }
            set { idDepartamento = value; }
        }

        public int IdProduto
        {
            get { return idProduto; }
            set { idProduto = value; }
        }
        public double Comissao
        {
            get { return comissao; }
            set { comissao = value; }
        }

    }
}