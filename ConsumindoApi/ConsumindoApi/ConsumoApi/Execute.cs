using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsumindoApi.ConsumoApi
{
    public static class Execute
    {
        public static readonly HttpClient _ViaCep = new HttpClient();

        public static T GetT<T>(string url)
        {
           var response = _ViaCep.GetAsync(url).Result;

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
                throw new Exception("Erro" + response.Content.ReadAsStringAsync().Result);

            return JsonConvert.DeserializeObject<T>(response.Content.ReadAsStringAsync().Result);
        }
    }
}
