using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Restaurante.Controllers
{
    [ApiController]
    public class MesasController : ControllerBase
    {
        private readonly Conexões.Sql _sql;
        public MesasController()
        {
            _sql = new Conexões.Sql();
        }
        [HttpPost("v1/ClienteMesas")]
        public void InserirMesas(Entidades.Mesas mesas)
        {
            _sql.InserirMesas(mesas);
        }
        [HttpPut("v1/ClienteMesas")]
        public void AtualizarMesas(Entidades.Mesas mesas)
        {
            _sql.AtualizarMesas(mesas);
        }
        [HttpDelete("v1/ClienteMesas")]
        public void DeletarMesas(Entidades.Mesas mesas)
        {
            _sql.DeletarMesas(mesas);
        }
        [HttpGet("v1/ClienteMesas")]
        public List<Entidades.Mesas> ListarMesas()
        {
            return _sql.ListarMesas();
        }
        [HttpGet("v1/ClienteMesas{id}")]
        public Entidades.Mesas ListarMesas(string Identificador)
        {
            return _sql.SelecionarMesas(Identificador);
        }
        [HttpGet("v1/Reservas")]
        public List<Entidades.Reserva> ListarReservas()
        {
            return _sql.ListarReservas();
        }
       
     }
}   