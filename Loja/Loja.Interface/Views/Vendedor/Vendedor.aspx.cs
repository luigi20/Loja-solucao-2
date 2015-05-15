using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Loja.Interface.Views.Vendedor
{
    public partial class Vendedor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrar_Command(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "New")
            {


                int inserir = Loja.Fachada.Fachada.VendedorFachada.Insert(Convert.ToInt32(ddlDepartamento.SelectedValue),
                                                                         txtBoxNome.Text,
                                                                         Convert.ToDouble(txtBoxPreco.Text),
                                                                         Convert.ToInt32(txtBoxQuantidade.Text),
                                                                         Convert.ToInt32(ddlProdutoSimilar.SelectedValue));

                if (inserir == 1)
                {


                    txtBoxPreco.Text = "";
                    txtBoxNome.Text = "";
                    txtBoxQuantidade.Text = "";
                    ddlDepartamento.SelectedIndex = -1;
                    this.ExibirMensagem("Produto Inserido Com Sucesso");
                    return;
                }
            }
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {

        }
    }
}