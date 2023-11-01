using CalculadoraCDB.Application.DTOs;
using CalculadoraCDB.Application.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace CalculadoraCDB.API.Controllers
{      

    [Route("api/calculadora")]
    [ApiController]
    public class CalculadoraController : ControllerBase
    {
        private readonly ICalcularCdbService _calcularCDBService;

        public CalculadoraController(ICalcularCdbService calcularCDBService)
        {
            _calcularCDBService = calcularCDBService;
        }

        [Route("CDB")]
        [EnableCors()]
        [HttpPost]
        public IActionResult CalcularCDB(AplicacaoDto inputModel) 
        {
            var result = _calcularCDBService.CalcularCDB(inputModel);

            if(result == null) 
            {
                return NotFound();
            }

            return Ok(result);
        }

    }
}
