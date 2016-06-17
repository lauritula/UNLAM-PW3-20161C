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
    public partial class eventos : System.Web.UI.Page
    {
        CocineroRepositorio CocRepo = new CocineroRepositorio();

        protected void Page_Load(object sender, EventArgs e)
        {
            sltNombreEvento.textoLabel = "Nombre del Evento: ";
            sltDescripcion.textoLabel = "Descripcion: ";
            sltCantComensales.textoLabel = "Cantidad de Comensales: ";
            sltUbicacion.textoLabel = "Ubicacion del Evento: ";
            txtFotoEvento.Text = Convert.ToString(fuFotoEvento.FileName);

            if (IsPostBack)
            {
                Boolean fileOK = false;
                String path = Server.MapPath("~/img/eventos/");
                if (fuFotoEvento.HasFile)
                {
                    txtFotoEvento.Text = path + fuFotoEvento.FileName;
                    String fileExtension =
                        System.IO.Path.GetExtension(fuFotoEvento.FileName).ToLower();
                    String[] allowedExtensions = { ".gif", ".png", ".jpeg", ".jpg" };
                    
                    for (int i = 0; i < allowedExtensions.Length; i++)
                    {
                        if (fileExtension == allowedExtensions[i])
                        {
                            fileOK = true;
                        }
                    }
                }

                if (fileOK)
                {
                    try
                    {
                        fuFotoEvento.PostedFile.SaveAs(path + fuFotoEvento.FileName);
                        lblFileOk.Text = "Subido con Exito.";
                    }
                    catch (Exception ex)
                    {
                        lblFileOk.Text = "La imagen no se pudo subir.";
                    }
                }
                else
                {
                    lblFileOk.Text = "No se aceptan archivos de ese tipo.";
                }
            }
        }

        protected void btnCrearEvento_Click(object sender, EventArgs e)
        {
            string nombreEvento = sltNombreEvento.textoTextbox;
            string descripcion = sltDescripcion.textoTextbox;
            string cantComensales = sltCantComensales.textoTextbox;
            string ubicacion = sltUbicacion.textoTextbox;
            string eventoFoto = txtFotoEvento.Text;

            Eventos nuevoEvento = new Eventos();
            nuevoEvento.Nombre = nombreEvento;
            nuevoEvento.Descripcion = descripcion;
            nuevoEvento.CantidadComensales = Convert.ToInt32(cantComensales);
            nuevoEvento.Ubicacion = ubicacion;
            nuevoEvento.Fecha = Convert.ToDateTime(cFechaEvento);
            nuevoEvento.IdUsuario = Convert.ToInt32(HttpContext.Current.Session["usuario"]);
            nuevoEvento.NombreFoto = eventoFoto;
   //         nuevoEvento.Recetas = cblRecetas;
            CocRepo.CrearEvento(nuevoEvento);

            Response.Redirect("default.aspx");

        }
    }
}