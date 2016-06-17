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
        
        public static List<Comentarios> ListaComentarios = new List<Comentarios>(); //ctrl + . para agregar el  using de "Entidades"

        public void Crear(Comentarios com)
        {
            ListaComentarios.Add(com);
        }

        public void Limpiar(Comentarios com)
        {
            ListaComentarios.Clear();
        }

        public List<Comentarios> ObtenerPorEvento(int evento)
        {
            List<Comentarios> comentarioXEvento = new List<Comentarios>();
            foreach (Comentarios co in ListaComentarios)
            {
                if (co.IdEvento == evento)
                    comentarioXEvento.Add(co);
            }
            return comentarioXEvento;
         }


        public Comentarios Obtener(int com)
        {
          //  Comentario nuevoCom = new Comentario();

            foreach (Comentarios L in ListaComentarios)
            {
                if (L.IdComentario == com)
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

    
    }
}