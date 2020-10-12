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
    public class AusenciaService
    {
        static readonly HttpClient client = new HttpClient();

        public static async Task<Ponto> postAusencia(Ponto ponto)
        {
            var response = await client.PostAsync($"http://localhost:5000/usuario/{ponto.IdUsuario}ponto", new StringContent(JsonConvert.SerializeObject(ponto)));
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Ponto>(responseBody);
        }
    }
}
