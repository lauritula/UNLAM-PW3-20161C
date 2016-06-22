using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Entidades;
using Repositorio;

namespace UNLAM_PW3_20161C.comensales
{
    public partial class reservas : System.Web.UI.Page
    {
        ComensalRepositorio ReserRepo = new ComensalRepositorio();
        CocineroRepositorio CocRepo = new CocineroRepositorio();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarGrillaReservas();
                CargarGrillaEventosFinalizados();

            }
        }

        private void CargarGrillaReservas()
        {
            int usuario = Convert.ToInt32(HttpContext.Current.Session["userID"]);

            List<Eventos> eventos = ReserRepo.reservaPorUsuario(usuario).ToList();
            if (eventos != null)
            {
                DataTable table = new DataTable("Tabla1");
                table.Columns.Add(new DataColumn("IdEvento", typeof(int)));
                table.Columns.Add(new DataColumn("Nombre", typeof(string)));
                table.Columns.Add(new DataColumn("Fecha", typeof(string)));
                table.Columns.Add(new DataColumn("Descripcion", typeof(string)));
                table.Columns.Add(new DataColumn("Ubicacion", typeof(string)));
                table.Columns.Add(new DataColumn("Precio", typeof(int)));
                table.Columns.Add(new DataColumn("Estado", typeof(string)));

                foreach (Eventos ev in eventos)
                {
                    DataRow row = table.NewRow();
                    row["IdEvento"] = ev.IdEvento;
                    row["Nombre"] = ev.Nombre;
                    row["Fecha"] = ev.Fecha;
                    row["Descripcion"] = ev.Descripcion;
                    row["Ubicacion"] = ev.Ubicacion;
                    row["Precio"] = ev.Precio;
                    switch (ev.Estado) //estado 1 = Programado, 2 = en curso, 3 = finalizado, 4 = Cancelado
                    {
                        case 1:
                            row["Estado"] = "Programado";
                            break;
                        case 2:
                            row["Estado"] = "En curso";
                            break;
                        case 3:
                            row["Estado"] = "Finalizado";
                            break;
                        case 4:
                            row["Estado"] = "Cancelado";
                            break;
                        default:
                            row["Estado"] = "Quien sabe";
                            break;
                    }

                    table.Rows.Add(row);
                }
                gvReservasActivas.DataSource = table;
                gvReservasActivas.AutoGenerateColumns = false;
                gvReservasActivas.DataBind();
            }
        }

        private void CargarGrillaEventosFinalizados()
        {
            int usuario = Convert.ToInt32(HttpContext.Current.Session["userID"]);
            gvEventosFinalizados.DataSource = ReserRepo.reservaFinalizados(usuario).ToArray();
            gvEventosFinalizados.AutoGenerateColumns = false;
            gvEventosFinalizados.DataBind();
        }
              
    }
}