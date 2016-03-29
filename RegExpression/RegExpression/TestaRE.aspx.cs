using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegExpression
{
    public partial class TestaRE : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected bool Validar(string mascara, string texto)
        {
            return Regex.IsMatch(texto, mascara);
        }

        protected MatchCollection Subtring(string mascara, string texto)
        {
            return new Regex(mascara).Matches(texto);
        }

        protected void btnVerificar_Click(object sender, EventArgs e)
        {
            string mascara = @"[:;,.!?][^ ]";
            string cep = @"^\d{5}-\d{3}$";
            string cpf = @"^\d{3}.\d{3}.\d{3}-\d{2}$";
            string cel = @"^\(\d{2}\) \d{5}-\d{4}$";
            string pla = @"^\[A-Z]{3}[^_]-\d{4}$";

            if (Validar(mascara, txtTexto.Text.ToString()))
                lblMensagem.Text = "Expressão Válida";

            if (Validar(cep, txtTexto.Text.ToString()))
                lblMensagem.Text = "CEP Válido";

            if (Validar(cpf, txtTexto.Text.ToString()))
                lblMensagem.Text = "CPF Válido";

            if (Validar(cel, txtTexto.Text.ToString()))
                lblMensagem.Text = "Celular Válido";

            if (Validar(pla, txtTexto.Text.ToString()))
                lblMensagem.Text = "Placa Válida";
            //else
            //{
            //    MatchCollection listaValores = Subtring(mascara, txtTexto.Text.ToString());
            //    lbxListaErro.DataSource = listaValores;
            //    lbxListaErro.DataBind();
            //}
        }
    }
}