using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DesktopPonto.Models;
using Newtonsoft.Json;

namespace DesktopPonto.Service
{
    class PontoService
    {
        static readonly HttpClient client = new HttpClient();

        public static async Task<Ponto> postPonto(Ponto ponto)
        {
            var content = new StringContent(JsonConvert.SerializeObject(ponto), Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"http://localhost:5000/ponto", content);
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Ponto>(responseBody);
        }
    }
}
