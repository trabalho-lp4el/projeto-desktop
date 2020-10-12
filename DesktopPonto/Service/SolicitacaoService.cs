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
    public class SolicitacaoService
    {
        static readonly HttpClient client = new HttpClient();

        public static async Task<Ponto> putPonto(Ponto ponto)
        {
            try
            {
                HttpContent content = new StringContent(JsonConvert.SerializeObject(ponto));
                var response = await client.PutAsync("http://localhost:5000/ponto", content);
                response.EnsureSuccessStatusCode();
                var responseBody = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<Ponto>(responseBody);
            } 
            catch (HttpRequestException e)
            {
                return null;
            }
           
            
        }

    }
}
