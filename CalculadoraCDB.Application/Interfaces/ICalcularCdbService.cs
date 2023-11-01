using CalculadoraCDB.Application.DTOs;

namespace CalculadoraCDB.Application.Interfaces
{
    public interface ICalcularCdbService
    {
        CalculoDto CalcularCDB(AplicacaoDto aplicationDto);
    }
}
