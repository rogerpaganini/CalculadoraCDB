using System.ComponentModel.DataAnnotations;

namespace CalculadoraCDB.Application.DTOs
{
    public class AplicacaoDto
    {
        [Required(ErrorMessage = "Informe o valor aplicado")]
        public double ValorAplicado { get; set; }

        [Required(ErrorMessage = "Informe a quantidade de meses")]
        public int QuantidadeMeses { get; set; }

        public void RetornarErroSeForInvalido()
        {
            if (ValorAplicado == 0)
                throw new ArgumentException("O valor do investimento deve ser maior que zero.");
            if (QuantidadeMeses <= 1)
                throw new ArgumentException("O prazo do investimento deve ser ser maior que um.");
        }
    }
}
