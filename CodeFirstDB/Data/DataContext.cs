using CodeFirstDB.Controllers;
using Microsoft.EntityFrameworkCore;


namespace CodeFirstDB.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("DefaultConnection");
        }*/

        public DbSet<WeatherForecast> Forecasts { get; set; }

    }
}
