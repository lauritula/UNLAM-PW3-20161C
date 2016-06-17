using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Repositorio;

namespace UNLAM_PW3_20161C.cocineros
{
    public partial class perfil : System.Web.UI.Page
    {
        CocineroRepositorio CocRepo = new CocineroRepositorio();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarGrillaEventos();
                CargarGrillaRecetas();
            }
        }

        private void CargarGrillaEventos()
        {
            int usuario = Convert.ToInt32(HttpContext.Current.Session["userID"]);
            gvEventosPerfil.DataSource = CocRepo.eventoPorUsuario(usuario);
            gvEventosPerfil.DataBind();
        }

        private void CargarGrillaRecetas()
        {
            int usuario = Convert.ToInt32(HttpContext.Current.Session["userID"]);
            gvRecetasPerfil.DataSource = CocRepo.recetasPorUsuario(usuario);
            gvRecetasPerfil.DataBind();
        }*/
    }
}