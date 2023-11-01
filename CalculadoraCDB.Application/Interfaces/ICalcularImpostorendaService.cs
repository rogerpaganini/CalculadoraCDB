using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCDB.Application.Interfaces
{
    public interface ICalcularImpostorendaService
    {
        double CalcularImpostoRenda(double valorInicial, double valorAtual, int mes);
    }
}
