using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Repositorio;

namespace UNLAM_PW3_20161C.cocineros
{
    public partial class Cocinero : System.Web.UI.MasterPage
    {
        public UsuarioRepositorio userRepo = new UsuarioRepositorio();

        protected void Page_Load(object sender, EventArgs e)
        {
            Usuarios objUsuario = (Usuarios)Session["objUsuario"];
            if (objUsuario == null)
            {
                Response.Redirect("~/default.aspx");
            }
            else
            {
                switch (objUsuario.IdTipoUsuario)
                {
                    case 1:
                        Response.Redirect("~/comensales/reservas.aspx");
                        break;
                    default:
                        break;
                }
            }

        }
    }
}