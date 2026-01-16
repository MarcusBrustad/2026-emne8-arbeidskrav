using MeaningOfLife.Models;

namespace MeaningOfLife.Repositories;

public interface IMeaningOfLifeRepository
{
    Task<MeaningOfLifeModel?> GetMeaningAsync();
}
