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

        public static async Task<Solicitacao> postSolicitacao(Solicitacao solicitacao)
        {
            try
            {
                HttpContent content = new StringContent(JsonConvert.SerializeObject(solicitacao));
                var response = await client.PostAsync("http://localhost:5000/solicitacao", content);
                response.EnsureSuccessStatusCode();
                var responseBody = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<Solicitacao>(responseBody);
            } 
            catch (HttpRequestException e)
            {
                return null;
            }
        }


        public static async Task<Ponto> getPonto(long idPonto)
        {
            try
            {
                var responseBody = await client.GetStringAsync($"http://localhost:500/ponto/{idPonto}");
                return JsonConvert.DeserializeObject<Ponto>(responseBody);
            } 
            catch (HttpRequestException e)
            {
                return null;
            }
        }

    }
}
