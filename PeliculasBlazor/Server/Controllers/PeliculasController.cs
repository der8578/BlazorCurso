using Microsoft.AspNetCore.Mvc;
using PeliculasBlazor.Server.Helpers;
using PeliculasBlazor.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculasBlazor.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PeliculasController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IAlmacenadorArchivos almacenadorDeArchivos;
 

        public PeliculasController(ApplicationDbContext context,
            IAlmacenadorArchivos almacenadorDeArchivos)
        {
            this.context = context;
            this.almacenadorDeArchivos = almacenadorDeArchivos; 
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Pelicula pelicula)
        {
            if (!string.IsNullOrWhiteSpace(pelicula.Poster))
            {
                var fotoPersona = Convert.FromBase64String(pelicula.Poster);
                pelicula.Poster = await almacenadorDeArchivos.GuardarArchivo(fotoPersona, "jpg", "peliculas");
            }

            if (pelicula.PeliculasActor != null)
            {
                for (int i = 0; i < pelicula.PeliculasActor.Count; i++)
                {
                    pelicula.PeliculasActor[i].Orden = i + 1;
                }
            }

            context.Add(pelicula);
            await context.SaveChangesAsync();
            return pelicula.Id;
        }
    }
}
