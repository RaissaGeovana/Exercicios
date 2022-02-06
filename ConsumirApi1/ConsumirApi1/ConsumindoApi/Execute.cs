using System;
using System.Net.Http;
using Newtonsoft.Json;
namespace ConsumirApi1.ConsumindoApi
{
    public class Execute
    {
        public static readonly HttpClient _ViaCep = new HttpClient();

        public static T GetT<T>(string url)
        {
            var response = _ViaCep.GetAsync(url).Result;

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                return JsonConvert.DeserializeObject<T>(response.Content.ReadAsStringAsync().Result);

            else
                throw new Exception("Serviço de consulta ao cep indisponível no momento.");
        }

        public static T Post<T>(string url, object obj)
        {
            string json = JsonConvert.SerializeObject(obj);


            var response = _ViaCep.PostAsync(url, new StringContent(json, System.Text.Encoding.UTF8, "application/json")).GetAwaiter().GetResult();

            var content = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                return JsonConvert.DeserializeObject<T>(content);
            else
                throw new Exception("Serviço de consulta ao cep indisponível no momento.");
        }
    }

}
