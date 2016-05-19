using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entidades;


namespace Repositorio
{
    public class ComentariosRepositorio
    {
        public static List<Comentario> ListaComentarios = new List<Comentario>(); //ctrl + . para agregar el  using de "Entidades"

        public void Crear(Comentario com)
        {
            ListaComentarios.Add(com);
        }

        public void Limpiar(Comentario com)
        {
            ListaComentarios.Clear();
        }

        public List<Comentario> ObtenerTodos()
        {
            return ListaComentarios;
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
            nuevoComent.comentarioUsuario = "maria";
            nuevoComent.comentarioDescripcion = "Todo muy rico";
            ListaComentarios.Add(nuevoComent);

            Comentario nuevoComent1 = new Comentario();
            nuevoComent1.comentarioID = 1;
            nuevoComent1.comentarioUsuario = "maria";
            nuevoComent1.comentarioDescripcion = "Todo muy rico";
            ListaComentarios.Add(nuevoComent1);

            Comentario nuevoComent2 = new Comentario();
            nuevoComent2.comentarioID = 1;
            nuevoComent2.comentarioUsuario = "maria";
            nuevoComent2.comentarioDescripcion = "Todo muy rico";
            ListaComentarios.Add(nuevoComent2);
        }
    
    }
}