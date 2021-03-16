using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PeliculasBlazor.Client.Repositorios
{
    public class HttpResponseWrapper<T>
    {
        public bool Error { get; set; }
        public T Response { get; set; }
        public HttpResponseMessage HttpResponseMessage { get; set; }

        public HttpResponseWrapper(T Response, bool error, HttpResponseMessage httpResponseMessage) => (this.Response, Error, HttpResponseMessage) = (Response, error, httpResponseMessage);
        public async Task<string> GetBody()
        {
            return await HttpResponseMessage.Content.ReadAsStringAsync();
        }

    }
}
