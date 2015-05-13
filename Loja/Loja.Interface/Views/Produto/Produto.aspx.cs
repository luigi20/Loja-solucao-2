using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Loja.Interface.Views.Produto
{
    public partial class Produto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ddlDepartamento.SelectedIndex = -1;
        }

        protected void btnCadastrar_Command(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "New")
            {


                int inserir = Loja.Fachada.Fachada.ProdutoFachada.Insert(txtBoxNome.Text,
                                                                         Convert.ToDouble(txtBoxPreco.Text),
                                                                         Convert.ToInt32(txtBoxQuantidade.Text),
                                                                         Convert.ToInt32(ddlDepartamento.DataTextField));

                if (inserir == 1)
                {


                    txtBoxPreco.Text = "";
                    txtBoxNome.Text = "";
                    txtBoxQuantidade.Text = "";
                    ddlDepartamento.SelectedIndex = -1;
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
    }
}