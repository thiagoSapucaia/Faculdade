using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegExpression {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }
        protected bool Validar(string mascara, string texto) {
            return Regex.IsMatch(texto, mascara);
        }


        protected void btnVerificar_Click(object sender, EventArgs e) {
            string mascara = @"(^\d{2}\.\d{3}\.\d{3}\/\d{4}\-\d{2})$";

            if (Validar(mascara, txtTexto.Text.ToString()))
                lblMensagem.Text = "CNPJ Válido";
            else
                lblMensagem.Text = "CNPJ inválido";
        }
    }
}