namespace ConsumirApi1
{
    public class Fluxo
    {
        public void Go()
        {
            var retornoApi = ConsumindoApi.Execute.GetT<ConsumindoApi.Contrato.ApiViaCep.GetViaCep.Response>("http://viacep.com.br/ws/33125210/json/ ");
        }

        public void Go1()
        {
            var retornoApi1 = ConsumindoApi.Execute.GetT<ConsumindoApi.Contrato.ApiViaCep.GetViaCep.GetViacepParametros.Response1>("http://viacep.com.br/ws/?cep={33125210}&logadouro={casa}&complemento={ola}&bairro={tx}&localidade={oi}&uf={id}&ibge={ra}&gia={ola}&id={lol}&siafi={pol}");
        }
    }
}
