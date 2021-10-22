using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroCertificados.Models
{
    public class Certificado
    {
        public int Id { get; set; }
        public string NomeCertificado { get; set; }

        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }

        public string TipoCertificado { get; set; }
        public float TempoCertificado { get; set; }
        public string LinkCertificado { get; set; }
        public string StatusCertificado { get; set; }
    }
}
