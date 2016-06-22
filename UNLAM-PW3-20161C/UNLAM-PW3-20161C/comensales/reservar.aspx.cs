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
    public partial class reservar : System.Web.UI.Page
    {
        ComensalRepositorio ReserRepo = new ComensalRepositorio();
        CocineroRepositorio CocRepo = new CocineroRepositorio();


        protected void Page_Load(object sender, EventArgs e)
        {
            sltReservaComensales.textoLabel = "Cantidad de comensales: ";         
            CargarGrillaEventosDisponibles();

        }

        private void CargarGrillaEventosDisponibles()
        {
            gvEventosDisponibles.DataSource = CocRepo.eventoDisponibles().ToArray();
            gvEventosDisponibles.AutoGenerateColumns = false;
            gvEventosDisponibles.DataBind();
            ddlMenu.DataSource = CocRepo.obtenerRecetas().ToList();
            ddlMenu.DataTextField = "Nombre";
            ddlMenu.DataValueField = "idReceta";
            ddlMenu.DataBind();
        }

        protected void btnReservar_Click(object sender, EventArgs e)
        {
            GridViewRow row = gvEventosDisponibles.SelectedRow;
            Reservas nuevaReserva = new Reservas();
            int cantidad = Convert.ToInt32(sltReservaComensales.textoTextbox);
            int IdEvento = Convert.ToInt32(row.Cells[0].Text);
            nuevaReserva.Cantidad = cantidad;
            nuevaReserva.IdReceta = Convert.ToInt32(ddlMenu.SelectedValue);
            nuevaReserva.IdEvento = IdEvento;
            nuevaReserva.IdUsuario = Convert.ToInt32(HttpContext.Current.Session["userID"]);

            ReserRepo.CrearReserva(nuevaReserva);
        }

        protected void gvEventosDisponibles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}