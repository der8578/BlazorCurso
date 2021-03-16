using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculasBlazor.Client.Helpers
{
    public class MostrarMensajes : IMostrarMensajes
    {
        public async Task MostrarMensajeError(string Mensaje)
        {
            await  Task.FromResult(0);
        }
    }
}
