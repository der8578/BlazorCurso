using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculasBlazor.Client.Pages.Peliculas
{
    partial class VisualizarPelicula
    {
        [Parameter] public int PeliculaId { get; set; }
        [Parameter] public string NombrePelicula { get; set; }
        protected override void OnInitialized()
        {
            Console.WriteLine(PeliculaId);
        }
    }
}
