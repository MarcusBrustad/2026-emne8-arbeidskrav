using MeaningOfLife.Data;
using Microsoft.EntityFrameworkCore;
using MeaningOfLife.Models;

namespace MeaningOfLife.Repositories;

public class MeaningOfLifeRepository(MeaningOfLifeContext context) : IMeaningOfLifeRepository
{

    public async Task<MeaningOfLifeModel?> GetMeaningAsync()
    {
        return await context.MeaningsOfLife.FirstOrDefaultAsync();
    }
}
