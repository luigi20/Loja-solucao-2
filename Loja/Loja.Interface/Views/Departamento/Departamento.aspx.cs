using System;
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

        }

      

        protected void btnCadastrar_Command(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "New"){

                
                int inserir = Loja.Fachada.Fachada.DepartamentoFachada.Insert(txtBoxNome.Text, 
                                                                              txtBoxSigla.Text, Convert.ToDouble(txtBoxComissao.Text));

                if (inserir == 1){

                    
                    txtBoxComissao.Text = "";
                    txtBoxNome.Text = "";
                    txtBoxSigla.Text ="";
                    this.ExibirMensagem("Departamento Inserido Com Sucesso");
                }
            }
        }
        protected void ExibirMensagem(string mensagem)
        {
            ClientScript.RegisterStartupScript(System.Type.GetType("System.String"), "Alert",
               "<script language='javascript'> { window.alert(\"" + mensagem + "\") }</script>");
        }
       
    }
}