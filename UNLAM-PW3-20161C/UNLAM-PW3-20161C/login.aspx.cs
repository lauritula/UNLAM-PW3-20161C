using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Repositorio;

namespace UNLAM_PW3_20161C
{
    public partial class login : System.Web.UI.Page
    {
        public UsuarioRepositorio userRepo = new UsuarioRepositorio();

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
       //     string tipoUsuario = "anonimo";
            var objUsuario = userRepo.ObtenerUsuario(email, password);

            try
            {
                if (objUsuario.IdTipoUsuario == 0)
            {
                HttpContext.Current.Session["usuario"] = email;
                HttpContext.Current.Session["userID"] = objUsuario.IdUsuario;
                Session["objUsuario"] = objUsuario;
                Session.Add( Convert.ToString(objUsuario.IdTipoUsuario), objUsuario);
                Response.Redirect("cocineros/perfil.aspx");

            }
            else if (objUsuario.IdTipoUsuario == 1)
            {
                HttpContext.Current.Session["usuario"] = email;
                HttpContext.Current.Session["userID"] = objUsuario.IdUsuario;
                Session["objUsuario"] = objUsuario;
                Session.Add( Convert.ToString(objUsuario.IdTipoUsuario), objUsuario);
                Response.Redirect("comensales/reservas.aspx");

            }
            else
            {
                lblErrorLogin.Visible = true;
            }

            }
            catch (Exception)
            {
                lblErrorLogin.Visible = true;

            }

            

            

        }
    }
}