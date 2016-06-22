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
                CargarGrillaEventos();

            }

        }

        private void CargarGrillaEventos()
        {
            int usuario = Convert.ToInt32(HttpContext.Current.Session["userID"]);
            gvEventosCancelar.DataSource = CocRepo.eventoPorEstado(3, usuario).ToArray();
            gvEventosCancelar.AutoGenerateColumns = false;
            gvEventosCancelar.DataBind();
        }

        protected void gvEventosCancelar_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gvEventosCancelar.SelectedRow;
            int IdEvento = Convert.ToInt32(row.Cells[0].Text);
            CocRepo.cancelarEvento(IdEvento);
            Response.Redirect("perfil.aspx");
        }
    }
}