using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PeliculasBlazor.Shared.Entidades
{
    public class Pelicula
    {
        public int Id { get; set; }
        [Required]
        public string Titulo { get; set; }

        public string Resumen { get; set; }

        public bool EnCartelera { get; set; }
        public string Trailer { get; set; }
        [Required]
        public DateTime? FechaDeLanzamiento { get; set; }

        public string Poster { get; set; }

        public List<GeneroPelicula> GeneroPeliculas { get; set; } = new List<GeneroPelicula>();
        public List<PeliculaActor> PeliculasActor { get; set; }
        public string TituloCortado
        {
            get
            {
                if (string.IsNullOrWhiteSpace(Titulo))
                {
                    return null;
                }
                else if (Titulo.Length > 60)
                {
                    return Titulo.Substring(0, 60) + "...";
                }
                else
                {
                    return Titulo;
                }
            }
        }
    }
}
