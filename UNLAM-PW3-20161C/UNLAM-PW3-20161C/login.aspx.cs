using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UNLAM_PW3_20161C
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            sltEmail.textoLabel = "Email: ";
            sltPassword.textoLabel = "Contraseña: ";
            sltPassword.TextMode = TextBoxMode.Password;
            lblErrorLogin.Visible = false;

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            string email = sltEmail.textoTextbox;
            string password = sltPassword.textoTextbox;
            string tipousuario = "anonimo";

            if (email == "cocinero@cocinarte.com" && password == "cocinero")
            {
                tipousuario = "cocinero";
                Session["usuario"] = email;

                var objUsuario = new Usuario();
                objUsuario.User = email;
                objUsuario.TipoUsuario = tipousuario;
                Session["objUsuario"] = objUsuario;

                Response.Redirect("cocineros/perfil.aspx");
            }
            else if (email == "comensal@cocinarte.com" && password == "comensal")
            {
                tipousuario = "comensal";

                Session["usuario"] = email;

                var objUsuario = new Usuario();
                objUsuario.User = email;
                objUsuario.TipoUsuario = tipousuario;
                Session["objUsuario"] = objUsuario;

                Response.Redirect("comensales/reservas.aspx");
            }
            else
            {
                lblErrorLogin.Visible = true;
            }

            

        }
    }
}