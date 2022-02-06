using FluentAssertions.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;



namespace Restaurante.Controllers
{
    [ApiController]
    public class ReservaController : ControllerBase
    {
        
        private readonly Conexões.ReservaService _service;
        public ReservaController()
        {
            _service = new Conexões.ReservaService();
        }
        [HttpGet("Reserva/ConsultarDisponibilidade")]
        public List<Entidades.Mesas> ConsultarDisponibilidadeV2(short quantidadeCadeiras, DateTime dataInicio, DateTime dataFim)
        {
            return _service.ConsultarDisponibilidadeV2(quantidadeCadeiras, dataInicio, dataFim);
        }
       
    }
}
