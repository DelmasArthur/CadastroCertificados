﻿// <auto-generated />
using CadastroCertificados.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CadastroCertificados.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20211022194142_TabelaCertificado")]
    partial class TabelaCertificado
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CadastroCertificados.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Curso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeAluno")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("CadastroCertificados.Models.Certificado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlunoId")
                        .HasColumnType("int");

                    b.Property<string>("LinkCertificado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeCertificado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatusCertificado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("TempoCertificado")
                        .HasColumnType("real");

                    b.Property<string>("TipoCertificado")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AlunoId");

                    b.ToTable("Certificados");
                });

            modelBuilder.Entity("CadastroCertificados.Models.Certificado", b =>
                {
                    b.HasOne("CadastroCertificados.Models.Aluno", "Aluno")
                        .WithMany("Certificados")
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aluno");
                });

            modelBuilder.Entity("CadastroCertificados.Models.Aluno", b =>
                {
                    b.Navigation("Certificados");
                });
#pragma warning restore 612, 618
        }
    }
}