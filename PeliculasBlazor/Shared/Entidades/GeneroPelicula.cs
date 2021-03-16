using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeliculasBlazor.Shared.Entidades
{
    public class GeneroPelicula
    {
        public int Id { get; set; }
        public int GeneroId { get; set; }

        public Genero Genero { get; set; }
        public Pelicula Pelicula { get; set;}
    }
}
