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
    public partial class ucEventoReciente : System.Web.UI.UserControl
    {
        public string textoLabelNombre
        {
            get { return lblNombre.Text; }
            set { lblNombre.Text = value; }
        }
        public string textoLabelPrecio
        {
            get { return lblPrecio.Text; }
            set { lblPrecio.Text = value; }
        }
        public string textoLabelPuntua
        {
            get { return lblPuntuacion.Text; }
            set { lblPuntuacion.Text = value; }
        }
        public string imagenSource
        {
            get { return imgEvento.ImageUrl; }
            set { imgEvento.ImageUrl = value; }
        }

        public CocineroRepositorio cociRepo = new CocineroRepositorio();

        protected void Page_Load(object sender, EventArgs e)
        {
            PW3_TP_20161CEntities Contexto = new PW3_TP_20161CEntities();
            foreach (Eventos item in Contexto.Eventos)
            {
                Eventos evento = cociRepo.ObtenerRecientes(item.IdEvento);
                if (evento != null)
                {
                    lblNombre.Text = evento.Nombre;
            lblPrecio.Text = Convert.ToString(evento.Precio);
            lblPuntuacion.Text = Convert.ToString(cociRepo.ObtenerPuntuacion(evento.IdEvento));
            imgEvento.ImageUrl = "~/img/eventos/" + evento.NombreFoto; 
                }
            
            }
            
        }

        protected void lbEventoReciente_Click(object sender, EventArgs e)
        {
            string Precio = lblPrecio.Text;
            string Puntuacion = lblPuntuacion.Text;
            string urlDestino = string.Format("~/eventoReciente.aspx?n={0}&pr={1}&pu={2}&f={3}",
                lblNombre.Text, Precio, Puntuacion, imgEvento.ImageUrl);
            Server.Transfer(urlDestino);

     //       Response.Redirect("~/eventoReciente.aspx");


        }
    }
}