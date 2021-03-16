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
    public class PersonasController : ControllerBase
    {
        private readonly ApplicationDbContext Context;
        private readonly IAlmacenadorArchivos AlmacenadorDeArchivos;
        public PersonasController(ApplicationDbContext context, IAlmacenadorArchivos almacenadorDeArchivos) => (Context, AlmacenadorDeArchivos) = (context, almacenadorDeArchivos);

        [HttpPost]
        public async Task<ActionResult<int>> Post(Persona persona)
        {
            if (!string.IsNullOrWhiteSpace(persona.Foto))
            {
                var fotoPersona = Convert.FromBase64String(persona.Foto);
                persona.Foto = await AlmacenadorDeArchivos.GuardarArchivo(fotoPersona, "jpg", "personas");
            }

            Context.Add(persona);
            await Context.SaveChangesAsync();
            return persona.Id;
        }
    }
}
