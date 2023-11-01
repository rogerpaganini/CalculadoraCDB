using CalculadoraCDB.Application.Interfaces;
using CalculadoraCDB.Application.Services;

namespace CalculadoraCDB.TesteUnitario.Application.Services
{
    public class CalcularInvestimentoTeste
    {
        private readonly ICalcularInvestimentoService _calcularInvestimentoService;

        public CalcularInvestimentoTeste()
        {
            _calcularInvestimentoService = new CalcularInvestimentoService();
        }

        [Theory]
        [InlineData(2000,6)]
        [InlineData(2360.24, 12)]
        [InlineData(12752.43, 20)]
        [InlineData(50000, 36)]
        [InlineData(80500.35, 48)]
        public void CalcularInvestimneto_ValorBrutoIgual_ValorInicialSomandoTaxas_RetornarValorCorreto(double valorAplicado, int quantidadeMes)
        {
            double valorAtual = 0;
            double valorEsperado = 0;
            double taxaBanco = 1.08; 
            double taxaCDI = 0.009; 

            for (int mes = 1; mes <= quantidadeMes; mes++)
            {
                valorEsperado = valorAplicado * (1 + taxaCDI * taxaBanco);
            }

            for (int mes = 1; mes <= quantidadeMes; mes++)
            {
                valorAtual = _calcularInvestimentoService.CalcularInvestimento(valorAplicado);

            }

            Assert.Equal(Math.Round(valorEsperado,2), Math.Round(valorAtual,2));
        }
    }
}
