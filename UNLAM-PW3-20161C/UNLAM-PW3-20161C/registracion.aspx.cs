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
    public partial class registracion : System.Web.UI.Page
    {
        public UsuarioRepositorio userRepo = new UsuarioRepositorio();
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
            byte tipo = Convert.ToByte(rblPerfil.SelectedValue);

            Usuarios usu = new Usuarios();
            usu.Nombre = nombre;
            usu.Email = email;
            usu.Password = password;
            usu.FechaRegistracion = System.DateTime.Now;
            usu.IdTipoUsuario = tipo;

            userRepo.Crear(usu);
            Response.Redirect("default.aspx");
        }
    }
}