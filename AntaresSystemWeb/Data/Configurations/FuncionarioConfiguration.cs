﻿using AntaresLibary.Models;
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
                .HasColumnType("varchar(10)")
                .IsRequired();

            builder.Property(w => w.DataNascimento)
                .IsRequired();

            builder.HasOne(w => w.Cargo).WithMany(w => w.Funcionarios).HasForeignKey(w => w.CargoId);
        }
    }
}