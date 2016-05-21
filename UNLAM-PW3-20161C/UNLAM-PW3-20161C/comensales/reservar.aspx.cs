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
            CocRepo.cargaFicticiaEventos2();
            CargarGrillaEventosDisponibles();

        }

        private void CargarGrillaEventosDisponibles()
        {
            gvEventosDisponibles.DataSource = CocRepo.eventoDisponibles("Finalizado");
            gvEventosDisponibles.DataBind();
        }

        protected void btnReservar_Click(object sender, EventArgs e)
        {
            Reserva nuevaReserva = new Reserva();
            int cantidad = Convert.ToInt32(sltReservaComensales.textoTextbox);
            nuevaReserva.comensalesReserva=cantidad;
            nuevaReserva.idReserva= nuevaReserva.idReserva + 1;
            nuevaReserva.recetaReserva = ddlMenu.SelectedValue;
            nuevaReserva.usuarioReserva = HttpContext.Current.Session["usuario"].ToString();
     //       nuevaReserva.eventoReserva = gvEventosDisponibles.checkbox;

            ReserRepo.CrearReserva(nuevaReserva);
        }


    }
}