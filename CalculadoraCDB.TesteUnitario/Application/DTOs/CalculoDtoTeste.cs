using CalculadoraCDB.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCDB.TesteUnitario.Application.DTOs
{
    public class CalculoDtoTeste
    {
        [Fact]
        public void ValidarValorAplicado_ValorIgualaZero_RetornarException()
        {
            var aplicacaoDto = new AplicacaoDto
            {
                ValorAplicado = 0,
                QuantidadeMeses = 5
            };

            // act & assert
            var exception = Assert.Throws<ArgumentException>(() => aplicacaoDto.RetornarErroSeForInvalido());
            Assert.Equal("O valor do investimento deve ser maior que zero.", exception.Message);


        }

        [Fact]
        public void ValidarQuantidadeDeMesesInformado_ValorMenorOuIgualaUm_RetornarException()
        {
            var aplicacaoDto = new AplicacaoDto
            {
                ValorAplicado = 1000,
                QuantidadeMeses = 1
            };

            // act & assert
            var exception = Assert.Throws<ArgumentException>(() => aplicacaoDto.RetornarErroSeForInvalido());
            Assert.Equal("O prazo do investimento deve ser ser maior que um.", exception.Message);


        }


        [Fact]
        public void ValidarAplicationDTO_ValorAplicadoEQuantidadeMesesCorretos_RetornarValidacaoComSucesso()
        {
            var aplicacaoDto = new AplicacaoDto
            {
                ValorAplicado = 150,
                QuantidadeMeses = 6
            };

            // act & assert
            aplicacaoDto.RetornarErroSeForInvalido();
            Assert.Equal("O valor do investimento deve ser maior que zero.", exception.Message);


        }

    }
}
