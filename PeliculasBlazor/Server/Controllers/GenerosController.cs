using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PeliculasBlazor.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculasBlazor.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    //[Route("~/api/Generos")]
    public class GenerosController: ControllerBase
    {

        private readonly ApplicationDbContext Context;
        public GenerosController(ApplicationDbContext context) => Context = context;

        [HttpPost]
        public async Task<ActionResult<int>> Post(Genero genero)
        {
            Context.Add(genero);
            await Context.SaveChangesAsync();
            return genero.Id;
        }

        [HttpGet]
        //[Route("~/api/Generos/")]
        public async Task<ActionResult<List<Genero>>> Get()
        {
            return await Context.Genero.ToListAsync();
        }
    }
}
