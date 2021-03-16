using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculasBlazor.Client.Helpers
{
    public interface IMostrarMensajes
    {
        Task MostrarMensajeError(string Mensaje);
    }
}
