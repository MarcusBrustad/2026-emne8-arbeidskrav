using System.ComponentModel.DataAnnotations.Schema;

namespace MeaningOfLife.Models;

[Table("MeaningOfLife")]
public class MeaningOfLifeModel
{
    public int Id { get; set; }
    public string Answer { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}
