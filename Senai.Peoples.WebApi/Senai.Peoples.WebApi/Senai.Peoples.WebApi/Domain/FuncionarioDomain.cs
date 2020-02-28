using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Peoples.WebApi.Domain
{
    public class FuncionarioDomain
    {
        public int IdFuncionario { get; set; }
        [Required (ErrorMessage = "Para de ser burro, imbecil, precisa do nome")]

        public string Nome { get; set; }
        [Required(ErrorMessage = "Para de ser burro, imbecil, precisa do sobenome")]

        public string Sobrenome { get; set; }

        public DateTime DataNasc { get; set; }

        public UsuarioDomain Usuario { get; set; }
    }
}
