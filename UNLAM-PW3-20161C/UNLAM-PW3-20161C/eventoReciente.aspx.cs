using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Repositorio;

namespace UNLAM_PW3_20161C
{
    public partial class eventoReciente : System.Web.UI.Page
    {
        ComentariosRepositorio ComentariosRepo = new ComentariosRepositorio();

        protected void Page_Load(object sender, EventArgs e)
        {
            lblNombre.Text = Request.QueryString["n"];
            lblPrecio.Text = Request.QueryString["pr"];
            lblPuntuacion.Text = Request.QueryString["pu"];
            imgEvento.ImageUrl = Request.QueryString["f"];

            if (!IsPostBack)
            {
                ComentariosRepo.cargaFicticiaComentario();
                CargarGrillaComentarios();
            }

        }

        private void CargarGrillaComentarios()
        {

            gvComentarios.DataSource = ComentariosRepo.ObtenerPorEvento(lblNombre.Text);
            gvComentarios.DataBind();
        }
    }
}