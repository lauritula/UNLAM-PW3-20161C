using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entidades;


namespace Repositorio
{
    public class ComentariosRepositorio
    {
        PW3_TP_20161CEntities Contexto;
        
        public ComentariosRepositorio()
        {
            Contexto = new PW3_TP_20161CEntities();
        }


        public static List<Comentario> ListaComentarios = new List<Comentario>(); //ctrl + . para agregar el  using de "Entidades"

        public void Crear(Comentario com)
        {
            ListaComentarios.Add(com);
        }

        public void Limpiar(Comentario com)
        {
            ListaComentarios.Clear();
        }

        public List<Comentario> ObtenerPorEvento(string evento)
        {
            List<Comentario> comentarioXEvento = new List<Comentario>();
            foreach (Comentario co in ListaComentarios)
            {
                if (co.comentarioEvento == evento)
                    comentarioXEvento.Add(co);
            }
            return comentarioXEvento;
                }

        public Comentario Obtener(int com)
        {
          //  Comentario nuevoCom = new Comentario();

            foreach (Comentario L in ListaComentarios)
            {
                if (L.comentarioID == com)
                {
                    return L;
                }
                else
                {
                    return null;
                }
            }

           throw new Exception("Comentario no encontrado");
                        
        }

        public void cargaFicticiaComentario()
        {
            Comentario nuevoComent = new Comentario();
            nuevoComent.comentarioID = 1;
            nuevoComent.comentarioEvento = "China Meal";
            nuevoComent.comentarioUsuario = "maria";
            nuevoComent.comentarioDescripcion = "Todo muy rico";
            ListaComentarios.Add(nuevoComent);

            Comentario nuevoComent1 = new Comentario();
            nuevoComent1.comentarioID = 2;
            nuevoComent1.comentarioEvento = "China Meal";
            nuevoComent1.comentarioUsuario = "maria";
            nuevoComent1.comentarioDescripcion = "Todo muy rico";
            ListaComentarios.Add(nuevoComent1);

            Comentario nuevoComent2 = new Comentario();
            nuevoComent2.comentarioID = 1;
            nuevoComent2.comentarioEvento = "Gourmet";
            nuevoComent2.comentarioUsuario = "maria";
            nuevoComent2.comentarioDescripcion = "Todo muy rico";
            ListaComentarios.Add(nuevoComent2);

            Comentario nuevoComent3 = new Comentario();
            nuevoComent3.comentarioID = 2;
            nuevoComent3.comentarioEvento = "Gourmet";
            nuevoComent3.comentarioUsuario = "Juan";
            nuevoComent3.comentarioDescripcion = "Todo muy rico";
            ListaComentarios.Add(nuevoComent3);

            Comentario nuevoComent4 = new Comentario();
            nuevoComent4.comentarioID = 1;
            nuevoComent4.comentarioEvento = "Italia Mia";
            nuevoComent4.comentarioUsuario = "maria";
            nuevoComent4.comentarioDescripcion = "Todo muy rico";
            ListaComentarios.Add(nuevoComent4);

            Comentario nuevoComent5 = new Comentario();
            nuevoComent5.comentarioID = 1;
            nuevoComent5.comentarioEvento = "Sushi";
            nuevoComent5.comentarioUsuario = "maria";
            nuevoComent5.comentarioDescripcion = "Todo muy rico";
            ListaComentarios.Add(nuevoComent5);

            Comentario nuevoComent6 = new Comentario();
            nuevoComent6.comentarioID = 1;
            nuevoComent6.comentarioEvento = "Todo Asado";
            nuevoComent6.comentarioUsuario = "maria";
            nuevoComent6.comentarioDescripcion = "Todo muy rico";
            ListaComentarios.Add(nuevoComent6);

            Comentario nuevoComent7 = new Comentario();
            nuevoComent7.comentarioID = 1;
            nuevoComent7.comentarioEvento = "Todo Postre";
            nuevoComent7.comentarioUsuario = "maria";
            nuevoComent7.comentarioDescripcion = "Todo muy rico";
            ListaComentarios.Add(nuevoComent7);
        }
    
    }
}