using CalculadoraCDB.Application.Interfaces;

namespace CalculadoraCDB.Application.Services
{
    public class CalcularInvestimentoService: ICalcularInvestimentoService
    {
        private const double TaxaBanco = 1.08; // 108%
        private const double TaxaCDI = 0.009; // 0.9%
                
        public double CalcularInvestimento(double valorInicial)
        {
            double valorFinal = valorInicial * (1 + TaxaCDI * TaxaBanco);
            return valorFinal;
        }
    }
}
