using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroCertificados.Models
{
    public class Aluno
    {
        public int Id { get; set; }

        [Display(Name = "Nome do Aluno")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string NomeAluno { get; set; }
        [Display(Name = "Curso")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Curso { get; set; }

        public List<Certificado> Certificados { get; set; }
    }
}
