﻿namespace ConsumirApi1.ConsumindoApi.Contrato.ApiViaCep.GetViaCep
{
    public class Response
    {
        public string cep { get; set; }
        public string logadouro { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string localidade { get; set; }
        public string uf { get; set; }
        public string ibge { get; set; }
        public string gia { get; set; }
        public string ddd { get; set; }
        public string siafi { get; set; }
    }
}
