using AulaCrudNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AulaCrudApresentacao
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                PreencherLista();
            }
        }

        private void PreencherLista()
        {
            PessoaNegocio p = new PessoaNegocio();

            var lista = p.Listar();

            ListaRepeater.DataSource = lista;
            ListaRepeater.DataBind();
        }

        protected void InserirButton_Click(object sender, EventArgs e)
        {
            PessoaNegocio p = new PessoaNegocio();

            try
            {
                p.Inserir(NomeTextBox.Text, IdadeTextBox.Text, CPFTextBox.Text);

                MensagemLabel.Text = "Pessoa Inserida com sucesso!";

                NomeTextBox.Text = "";
                IdadeTextBox.Text = "";
                CPFTextBox.Text = "";

                PreencherLista();
            }
            catch (Exception ex)
            {
                MensagemLabel.Text = ex.Message;
            }
        }

        protected void ListaRepeater_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Excluir")
            {
                var id = Convert.ToInt32(e.CommandArgument);

                PessoaNegocio p = new PessoaNegocio();

                p.Excluir(id);

                MensagemLabel.Text = "Pessoa excluída com sucesso!";
            }
            else if (e.CommandName == "Editar")
            {

            }

            PreencherLista();
        }
    }
}