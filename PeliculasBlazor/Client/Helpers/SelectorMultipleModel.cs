using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculasBlazor.Client.Helpers
{
    public struct  SelectorMultipleModel
    {
        public string Llave { get; set; }
        public string  Valor { get; set; }

 
        public SelectorMultipleModel(string llave, string valor) => (Llave, Valor) = (llave, valor);
    }
}
