using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UNLAM_PW3_20161C.cocineros
{
    public partial class perfil : System.Web.UI.Page
    {
        CocineroRepositorio CocRepo = new CocineroRepositorio();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CocRepo.cargaFicticiaRecetas();
                CargarGrillaRecetas();
            }
        }

        private void CargarGrillaRecetas()
        {
            string usuario = HttpContext.Current.Session["usuario"].ToString();
            gvRecetasPerfil.DataSource = CocRepo.recetasPorUsuario(usuario);
            gvRecetasPerfil.DataBind();
        }
    }
}