using CalculadoraCDB.Application.Interfaces;
using CalculadoraCDB.Application.Services;

namespace CalculadoraCDB.TesteUnitario.Application.Services
{
    public class CalcularImpostoTeste
    {
        private readonly ICalcularImpostorendaService _calcularImpostorendaService;
        public CalcularImpostoTeste()
        {
            _calcularImpostorendaService = new CalcularImpostorendaService();
        }
        [Theory]
        [InlineData(1200,1309,5)]
        [InlineData(2000, 2180, 6)]
        [InlineData(3500, 3720, 4)]
        [InlineData(5000, 5170, 3)]
        [InlineData(10000, 13209, 2)]
        public void CalcularValorImpostoRenda_DadoValorInicialEValorBruto_EQuantidadeDeMesesMenorque6_RetornarValorImpostoCorreto(double valorInicial,double valorAtual, int quantidadeMeses)
        {
            valorInicial = Math.Round(valorInicial, 2);
            valorAtual = Math.Round(valorAtual, 2);

            var valorEsperado = Math.Round((valorAtual - valorInicial) * 0.225, 2);
            var valorImposto = _calcularImpostorendaService.CalcularImpostoRenda(valorInicial, valorAtual, quantidadeMeses);

            Assert.Equal(valorEsperado, valorImposto);
        }

        [Theory]
        [InlineData(1200, 1309, 7)]
        [InlineData(2000, 2180, 9)]
        [InlineData(3500, 3720, 10)]
        [InlineData(5000, 5170, 11)]
        [InlineData(10000, 13209, 12)]
        public void CalcularValorImpostoRenda_DadoValorInicialEValorBruto_EQuantidadedeMesesMaiorque6_RetornarValorImpostoCorreto(double valorInicial, double valorAtual, int quantidadeMeses)
        {
            var valorEsperado = Math.Round((valorAtual - valorInicial) * 0.20, 2);
            var valorImposto = _calcularImpostorendaService.CalcularImpostoRenda(valorInicial, valorAtual, quantidadeMeses);

            Assert.Equal(valorEsperado, valorImposto);
        }

        [Theory]
        [InlineData(1200, 1309, 13)]
        [InlineData(2000, 2180, 15)]
        [InlineData(3500, 3720, 16)]
        [InlineData(5000, 5170, 20)]
        [InlineData(10000, 13209, 22)]
        public void CalcularValorImpostoRenda_DadoValorInicialEValorBruto_EQuantidadedeMesesMaiorque12_RetornarValorImpostoCorreto(double valorInicial, double valorAtual, int quantidadeMeses)
        {
            valorInicial = Math.Round(valorInicial, 2);
            valorAtual = Math.Round(valorAtual, 2);

            var valorEsperado = Math.Round((valorAtual - valorInicial) * 0.175, 2);
            var valorImposto = _calcularImpostorendaService.CalcularImpostoRenda(valorInicial, valorAtual, quantidadeMeses);

            Assert.Equal(valorEsperado, valorImposto);
        }

        [Theory]
        [InlineData(1200, 1309, 25)]
        [InlineData(2000, 2180, 28)]
        [InlineData(3500, 3720, 30)]
        [InlineData(5000, 5170, 36)]
        [InlineData(10000, 13209, 48)]
        public void CalcularValorImpostoRenda_DadoValorInicialEValorBruto_EQuantidadedeMesesMaiorque24_RetornarValorImpostoCorreto(double valorInicial, double valorAtual, int quantidadeMeses)
        {
            valorInicial = Math.Round(valorInicial, 2);
            valorAtual = Math.Round(valorAtual, 2);

            var valorEsperado = Math.Round((valorAtual - valorInicial) * 0.15, 2);
            var valorImposto = _calcularImpostorendaService.CalcularImpostoRenda(valorInicial, valorAtual, quantidadeMeses);

            Assert.Equal(valorEsperado, valorImposto);
        }
    }
}
