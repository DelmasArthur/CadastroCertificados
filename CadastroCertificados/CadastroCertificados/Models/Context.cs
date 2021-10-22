using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroCertificados.Models
{
    public class Context : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Certificado> Certificados { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=CertificadosJIX;Integrated Security=True");
        }
    }
}
