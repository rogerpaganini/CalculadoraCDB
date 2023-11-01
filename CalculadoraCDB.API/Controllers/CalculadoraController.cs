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
        private readonly ILogger<CalculadoraController> _logger;
        private readonly ICalcularCdbService _calcularCDBService;

        public CalculadoraController(ILogger<CalculadoraController> logger,
            ICalcularCdbService calcularCDBService)
        {
            _logger = logger;
            _calcularCDBService = calcularCDBService;
        }

        [Route("CDB")]
        [EnableCors()]
        [HttpPost]
        public IActionResult CalcularCDB(AplicacaoDto inputModel) 
        {
            try
            {
                var result = _calcularCDBService.CalcularCDB(inputModel);

                if(result == null) 
                {
                    return NotFound();
                }

                return Ok(result);
            }
            catch (Exception ex )
            {
                _logger.LogError(ex, "Erro ao caluclar CDB {0}", ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

    }
}
