using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Repositorio;
using Entidades;

namespace UNLAM_PW3_20161C.cocineros
{
    public partial class cancelar : System.Web.UI.Page
    {
        CocineroRepositorio CocRepo = new CocineroRepositorio();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CocRepo.cargaFicticiaEventos2();
                CargarGrillaEventos();

            }

        }

        private void CargarGrillaEventos()
        {
            string usuario = HttpContext.Current.Session["usuario"].ToString();
            gvEventosCancelar.DataSource = CocRepo.eventoPorEstado("Finalizado", usuario);
            gvEventosCancelar.DataBind();
           
        }

        protected void btnCancelarEvento_Click(object sender, EventArgs e)
        {
         //   gvEventosCancelar.DataSource = CocRepo.cancelarEvento();

        }
    }
}