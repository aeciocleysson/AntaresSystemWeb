﻿// <auto-generated />
using System;
using AntaresSystemWeb.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AntaresSystemWeb.Migrations.AntaresDb
{
    [DbContext(typeof(AntaresDbContext))]
    [Migration("20230324161559_v1.0.4")]
    partial class v104
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Domain.Models.Cargo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("Inserted")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsAtivo")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserAlteration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserInserted")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cargo", (string)null);
                });

            modelBuilder.Entity("Domain.Models.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CargoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Inserted")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsAtivo")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Matricula")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserAlteration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserInserted")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CargoId");

                    b.ToTable("Funcionario", (string)null);
                });

            modelBuilder.Entity("Domain.Models.LogPonto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Inserted")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsAtivo")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserAlteration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserInserted")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LogPonto");
                });

            modelBuilder.Entity("Domain.Models.Ponto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("Entrada")
                        .HasColumnType("time");

                    b.Property<int>("FuncionarioId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Inserted")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsAtivo")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("LogPontoId")
                        .HasColumnType("int");

                    b.Property<long>("Matricula")
                        .HasColumnType("bigint");

                    b.Property<double>("Minutos")
                        .HasColumnType("float");

                    b.Property<TimeSpan>("RetornoIntervalo")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("Saida")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("SaidaIntervalo")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("TotalIntervalo")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("TotalTrabalhado")
                        .HasColumnType("time");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserAlteration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserInserted")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FuncionarioId");

                    b.HasIndex("LogPontoId");

                    b.ToTable("Ponto");
                });

            modelBuilder.Entity("Domain.Models.Funcionario", b =>
                {
                    b.HasOne("Domain.Models.Cargo", "Cargo")
                        .WithMany("Funcionarios")
                        .HasForeignKey("CargoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cargo");
                });

            modelBuilder.Entity("Domain.Models.Ponto", b =>
                {
                    b.HasOne("Domain.Models.Funcionario", "Funcionario")
                        .WithMany()
                        .HasForeignKey("FuncionarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.LogPonto", "LogPonto")
                        .WithMany()
                        .HasForeignKey("LogPontoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Funcionario");

                    b.Navigation("LogPonto");
                });

            modelBuilder.Entity("Domain.Models.Cargo", b =>
                {
                    b.Navigation("Funcionarios");
                });
#pragma warning restore 612, 618
        }
    }
}