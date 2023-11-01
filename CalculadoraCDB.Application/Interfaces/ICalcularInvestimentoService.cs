using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCDB.Application.Interfaces
{
    public  interface ICalcularInvestimentoService
    {
        double CalcularInvestimento(double valorInicial);
    }
}
