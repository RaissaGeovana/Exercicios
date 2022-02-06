using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ConsumirApi1.Controllers
{

    [ApiController]
    public class ApiViaCep : ControllerBase

    {
        [HttpGet("v1/BuscaCep")]

        public void Fluxo(Fluxo go)
        {
            Fluxo(go);
        }
        [HttpGet("v1/BuscaCep/1")]

        public void Fluxo2(Fluxo go1)
        {
            Fluxo2(go1);
        }

        [HttpGet("v1/ConsultarCep")]
        public IActionResult ConsultarCep(string cep)
        {
          try
          { 

            if (string.IsNullOrWhiteSpace(cep) || cep.Length != 8)
            {
                throw new InvalidOperationException("Cep inválido.");
            }

            var retornoApi = ConsumindoApi.Execute.GetT<ConsumindoApi.Contrato.ApiViaCep.GetViaCep.Response>("http://viacep.com.br/ws/"+ cep + "/json/");
            return StatusCode(200, retornoApi);

          }
            catch (InvalidOperationException ex)
            {
                return StatusCode(400, ex.Message);
            }
            catch (Exception ex)
            {
                var log = new ConsumindoApi.Contrato.ApiViaCep.GetViaCep.GetViacepParametros.Response1();
                log.NomeAplicacao = "ApiCep";
                log.NomeMaquina = Environment.MachineName;
                log.DataHora = DateTime.Now;
                log.MensagemErro = ex.Message;
                log.RastreioErro = ex.StackTrace;
                log.Usuario = Environment.UserName;

                ConsumindoApi.Execute.Post<string>("https://logaplicacao.aiur.com.br/v1/Logs", log);
                return StatusCode(500, "Serviço indisponível no momento.");
          }

        }
    }
}
