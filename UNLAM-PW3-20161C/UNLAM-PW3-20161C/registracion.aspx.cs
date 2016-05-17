using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UNLAM_PW3_20161C
{
    public partial class registracion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            sltNombre.textoLabel = "Nombre: ";
            sltEmail.textoLabel = "Email: ";
            sltPassword.textoLabel = "Contraseña: ";
            sltConPassword.textoLabel = "Confirmar Contraseña: ";
            sltPassword.TextMode = TextBoxMode.Password;
            sltConPassword.TextMode = TextBoxMode.Password;
            

        }

        protected void btnRegistrarse_Click(object sender, EventArgs e)
        {
            string nombre = sltNombre.textoTextbox;
            string email = sltEmail.textoTextbox;
            string password = sltPassword.textoTextbox;
            string conpassword = sltConPassword.textoTextbox;
            
            Response.Redirect("default.aspx");
        }
    }
}