﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Loja.Interface.Views.Departamento
{
    public partial class Departamento : System.Web.UI.Page
    {
      
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
            {
                List<Loja.Objeto.Models.Departamento> listaDepartamento = Loja.Objeto.DAO.DepartamentoDAO.listarTodos(Convert.ToInt32(Request.QueryString["id"].ToString() ));
                foreach( Loja.Objeto.Models.Departamento departamento in listaDepartamento) 
                {
                    if (departamento.IdDepartamento.Equals(Convert.ToInt32(Request.QueryString["id"].ToString()))) 
                    {
                        txtBoxNome.Text = departamento.NomeDepartamento;
                        txtBoxComissao.Text = Convert.ToString( departamento.PercComissaoDepartamento);
                        txtBoxSigla.Text = departamento.SiglaDepartamento;
                        ddlIdChefe.SelectedValue = Convert.ToString(departamento.ChefeDepartamentoVendedor);
                        return;
                    }
                }
            }
        }

      

        protected void btnCadastrar_Command(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "New"){

                
                int inserir = Loja.Fachada.Fachada.DepartamentoFachada.Insert(txtBoxNome.Text, 
                                                                              txtBoxSigla.Text, 
                                                                              Convert.ToDouble(txtBoxComissao.Text),Convert.ToInt32(ddlIdChefe.SelectedValue));

                if (inserir == 1){

                    
                    txtBoxComissao.Text = "";
                    txtBoxNome.Text = "";
                    txtBoxSigla.Text ="";
                    this.ExibirMensagem("Departamento Inserido Com Sucesso");
                    return;
                }
            }
        }
        protected void ExibirMensagem(string mensagem)
        {
            ClientScript.RegisterStartupScript(System.Type.GetType("System.String"), "Alert",
               "<script language='javascript'> { window.alert(\"" + mensagem + "\") }</script>");
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {

        }
       
    }
}