using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Repositorio;

namespace UNLAM_PW3_20161C.comensales
{
    public partial class reservas : System.Web.UI.Page
    {
        ComensalRepositorio ReserRepo = new ComensalRepositorio();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ReserRepo.cargaFicticiaReserva();
                CargarGrillaReservas();
            }
        }

        private void CargarGrillaReservas()
        {
            string usuario = HttpContext.Current.Session["usuario"].ToString();
            gvReservas.DataSource = ReserRepo.reservaPorUsuario(usuario);
            gvReservas.DataBind();
        }
              
    }
}