using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AntaresSystemWeb.Data.Configurations
{
    public class FuncionarioConfiguration : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.ToTable("Funcionario");

            builder.Property(w => w.Nome)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(w => w.Matricula)
                .IsRequired();

            builder.Property(w => w.DataNascimento)
                .IsRequired();
            
        }
    }
}
