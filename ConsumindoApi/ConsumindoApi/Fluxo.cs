using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumindoApi
{
    internal class Fluxo
    {
        public void Go()
        {
           var retornoApi =  ConsumoApi.Execute.GetT<ConsumoApi.Contratos.ApiViaCep.GetViaCep.Response>("http://viacep.com.br/ws/33125210/json/ ");
        }
    }
}
