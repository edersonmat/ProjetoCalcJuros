using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto.Data.Contracts;
using Projeto.Data.Entities;
using Projeto.Services.Models;
using Projeto.Data.Repositories;

namespace Projeto.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculadorController : ControllerBase
    {
        [HttpGet]
        [Route("taxaJuros")]
        public IActionResult GetJuros()
        {
            var juros = Juros.Taxa;

            return Ok(juros);
        }

        [HttpPost]
        [Route("calculajuros")]
        public  IActionResult CalculaJuros(CalculaParcelaModel model, [FromServices] CalculadorRepository rep)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var parcela = new CalculaParcela();
                    parcela.Prazo = model.prazo;
                    parcela.Valor = model.valor;
                    var valorFinal = rep.Calcular(Juros.Taxa, parcela);
                    
                    return Ok(valorFinal.ToString("F"));

                }
                catch(Exception e)
                {
                    return StatusCode(500, e.Message);
                }
            }
            else
            {
                return BadRequest("Ocorreram erros de validação");
            }
        }

        [HttpGet]
        [Route("showmethecode")]
        public IActionResult GetRepository([FromServices] ShowCodeRepository rep)
        {
            try
            {
                var code = rep.ShowTheCode(CodeGit.Url);

                return Ok(code);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }

        }

    }

}
