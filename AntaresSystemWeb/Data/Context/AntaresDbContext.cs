using Domain.Models;
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
    }
}
