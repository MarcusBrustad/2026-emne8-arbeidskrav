using MeaningOfLife.Models;
using Microsoft.EntityFrameworkCore;


namespace MeaningOfLife.Data;

public class MeaningOfLifeContext : DbContext
{
    public MeaningOfLifeContext(DbContextOptions<MeaningOfLifeContext> options)
        : base(options)
    {
    }

    public DbSet<MeaningOfLifeModel> MeaningsOfLife { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<MeaningOfLifeModel>().HasData(
            new MeaningOfLifeModel
            {
                Id = 1,
                Answer = "42",
                Description = "The Answer to Life, Universe and Everything"
            }
        );
    }
}
