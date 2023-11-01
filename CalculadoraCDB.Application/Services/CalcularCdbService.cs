using CalculadoraCDB.Application.DTOs;
using CalculadoraCDB.Application.Interfaces;

namespace CalculadoraCDB.Application.Services
{
    public class CalcularCdbService : ICalcularCdbService
    {
        private readonly ICalcularInvestimentoService _calcularInvestimentoService;
        private readonly ICalcularImpostorendaService _calcularImpostorendaService;

        
        public CalcularCdbService(ICalcularInvestimentoService calcularInvestimentoService,
            ICalcularImpostorendaService calcularImpostorendaService)
        {
            _calcularImpostorendaService = calcularImpostorendaService;
            _calcularInvestimentoService = calcularInvestimentoService;
        }
        public CalculoDto CalcularCDB(AplicacaoDto aplicationDto)
        {
            aplicationDto.RetornarErroSeForInvalido();


            var calcularCDB = new CalculoDto
            {
                ValorAplicado = aplicationDto.ValorAplicado,
                QuantidadeMeses = aplicationDto.QuantidadeMeses
            };

            double valorAtual = aplicationDto.ValorAplicado;

            for (int mes = 1; mes <= aplicationDto.QuantidadeMeses; mes++)
            {
                valorAtual = _calcularInvestimentoService.CalcularInvestimento(valorAtual);
              
            }
            calcularCDB.ValorBruto = Math.Round(valorAtual,2);
            var impostoRenda = _calcularImpostorendaService.CalcularImpostoRenda(aplicationDto.ValorAplicado, valorAtual, aplicationDto.QuantidadeMeses);
            calcularCDB.ValorLiquido = valorAtual - impostoRenda;

            return calcularCDB;          
        }
    }
}
