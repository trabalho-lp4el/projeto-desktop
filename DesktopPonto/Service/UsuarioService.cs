using DesktopPonto.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DesktopPonto.Service
{
    public class UsuarioService
    {
        static readonly HttpClient client = new HttpClient();

        public static async Task<Usuario> getUsuario(long idUsuario)
        {
            try
            {
                var responseBody = await client.GetStringAsync($"http://localhost:5000/usuario/{idUsuario}");
                return JsonConvert.DeserializeObject<Usuario>(responseBody);
            } catch(HttpRequestException e)
            {
                return null;
            }
            
        }
    }
}
