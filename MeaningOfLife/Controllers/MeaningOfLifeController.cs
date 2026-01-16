using MeaningOfLife.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace MeaningOfLife.Controllers;

[ApiController]
[Route("api/themeaningoflife")]
public class MeaningOfLifeController(IMeaningOfLifeRepository repository) : ControllerBase
{

    [HttpGet]
    public async Task<IActionResult> GetMeaningOfLife()
    {
        var meaning = await repository.GetMeaningAsync();

        if (meaning == null)
        {
            return NotFound();
        }

        return Ok(new
        {
            answer = meaning.Answer,
            description = meaning.Description
        });
    }
}
