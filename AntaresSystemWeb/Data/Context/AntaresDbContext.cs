using AntaresLibary.Models;
using AntaresSystemWeb.Data.Configurations;
using Microsoft.EntityFrameworkCore;

namespace AntaresSystemWeb.Data.Context
{
    public class AntaresDbContext : DbContext
    {
        public AntaresDbContext(DbContextOptions<AntaresDbContext> options) : base(options)
        {
        }

        public AntaresDbContext()
        {
        }

        public DbSet<Cargo> Cargo { get; set; } = default!;
        public DbSet<Funcionario> Funcionario { get; set; } = default!;
        public DbSet<Ponto> Ponto { get; set; } = default!;
        public DbSet<LogPonto> LogPonto { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CargoConfiguration());
            modelBuilder.ApplyConfiguration(new FuncionarioConfiguration());
        }
    }
}