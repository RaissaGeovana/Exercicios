using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace Restaurante.Controllers
{
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly Conexões.Sql _sql;
        public ClienteController()
        {
            _sql = new Conexões.Sql();
        }

        [HttpPost("v1/Cliente")]
        public IActionResult InserirCliente(Entidades.Cliente cliente)
        {
            try
            {
                if (!Entidades.Validacao.ValidaCPF.IsCpf(cliente.Cpf))


                    throw new InvalidOperationException("Cpf Invalido");


                _sql.InserirCliente(cliente);
            }

            catch (InvalidOperationException ex)

            {

                return StatusCode(400, ex.Message);

            }
            catch (Exception)
            {

                return StatusCode(500);

            }
            return StatusCode(200);
        }
        [HttpPut("v1/Cliente")]
        public void AtualizarCliente(Entidades.Cliente cliente)
        {
           
                _sql.InserirCliente(cliente);
  
            
        }
        [HttpDelete("v1/Cliente")]
        public void DeletarCliente(Entidades.Cliente cliente)
        {
            _sql.DeletarCliente(cliente);
        }
        [HttpGet("v1/Cliente")]
        public List<Entidades.Cliente> ListarClientes()
        {
            return _sql.ListarClientes();
        }
        [HttpGet("v1/Cliente/{cpf}")]
        public Entidades.Cliente ListarClientes(string cpf)
        {
            return _sql.SelecionarCliente(cpf);
        }

    }

}      
            
        
    
