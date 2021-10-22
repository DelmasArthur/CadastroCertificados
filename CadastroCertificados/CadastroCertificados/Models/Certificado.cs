using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroCertificados.Models
{
    public class Certificado
    {
        public int Id { get; set; }

        [Display(Name = "Certificado")]
        public string NomeCertificado { get; set; }

        [Display(Name = "Aluno")]
        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }

        [Display(Name = "Tipo do Certificado")]
        public string TipoCertificado { get; set; }
        [Display(Name = "Quantidade de Horas")]
        public float TempoCertificado { get; set; }
        [Display(Name = "Link de Acesso")]
        public string LinkCertificado { get; set; }
        [Display(Name = "Status")]
        public string StatusCertificado { get; set; }
    }
}
