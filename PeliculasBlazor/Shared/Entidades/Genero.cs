using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeliculasBlazor.Shared.Entidades
{
    public class Genero
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="El {0} es requerido")]
        public string Nombre { get; set; }

        public List<GeneroPelicula> GeneroPeliculas { get; set; }
    }
}
