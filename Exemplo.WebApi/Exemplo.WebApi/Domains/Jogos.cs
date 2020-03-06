using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Exemplo.WebApi.Domains
{
    public partial class Jogos
    { 
        public int IdJogo { get; set; }

       
        
        public string NomeJogo { get; set; }

        

        public string Descricao { get; set; }

        
        public double? Preco { get; set; }


        public DateTime DataLanc { get; set; }

        public int IdEstudio { get; set; }

        public Estudio IdEstudioNavigation { get; set; }
    }
}
