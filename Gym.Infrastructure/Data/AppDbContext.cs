using Microsoft.EntityFrameworkCore;

namespace Gym.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Domain.Entities.Gym> Gyms { get; set; }
        public string DbPath { get; }

        public AppDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "Gym.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}
