using CalculadoraCDB.Application.DTOs;
using CalculadoraCDB.Application.Interfaces;
using CalculadoraCDB.Application.Services;
using Moq;

namespace CalculadoraCDB.TesteUnitario.Application.Services
{
    public class CalcularCdbTestes
    {
        private readonly Mock<ICalcularImpostorendaService> _mockICalcularImpostoRendaService;
        private readonly Mock<ICalcularInvestimentoService> _mockICalcularInvestimentoService;
        public CalcularCdbTestes()
        {
            _mockICalcularImpostoRendaService = new Mock<ICalcularImpostorendaService>();
            _mockICalcularInvestimentoService = new Mock<ICalcularInvestimentoService>();

        }

        [Theory]
        [InlineData(1000,3)]
        [InlineData(2000, 4)]
        [InlineData(3000, 5)]
        [InlineData(5000, 6)]
        [InlineData(8000, 21)]
        public void CalcularCDB_CalcularInvestimento_DeAcordoComQuantidadedeMeses(double valor, int quantidadeMeses)
        {
            //arrange

            ICalcularCdbService _calcularCdbService = new CalcularCdbService(_mockICalcularInvestimentoService.Object,
               _mockICalcularImpostoRendaService.Object);

            var aplicacaoInputModel = new AplicacaoDto
            {
                ValorAplicado = valor,
                QuantidadeMeses = quantidadeMeses
            };

            //act
            _calcularCdbService.CalcularCDB(aplicacaoInputModel);

            //assert
            _mockICalcularInvestimentoService.Verify(s => s.CalcularInvestimento(It.IsAny<double>()), Times.Exactly(quantidadeMeses));
        }

        [Theory]
        [InlineData(145.6785)]
        [InlineData(121.1253)]
        [InlineData(345.651)]
        [InlineData(12987.682)]
        public void CalcularCDB_ArredondaValorBrutoCom2CasasDecimais(double valorInvestimento)
        {
            //arrange
            var valorBrutoEsperado = Math.Round(valorInvestimento, 2);

            _mockICalcularInvestimentoService.Setup(s => s.CalcularInvestimento(It.IsAny<double>())).Returns(valorInvestimento);
            ICalcularCdbService _calcularCdbService = new CalcularCdbService(_mockICalcularInvestimentoService.Object,
               _mockICalcularImpostoRendaService.Object);

            var aplicacaoInputModel = new AplicacaoDto
            {
                ValorAplicado = 1000.00,
                QuantidadeMeses = 6
            };

            //act
            var result = _calcularCdbService.CalcularCDB(aplicacaoInputModel);

            //assert
            Assert.Equal(valorBrutoEsperado, result.ValorBruto);
        }

    }
}