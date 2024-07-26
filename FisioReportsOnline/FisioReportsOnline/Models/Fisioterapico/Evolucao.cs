using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisioReportsOnline.Models.Fisioterapico
{
    public class Evolucao
    {
        public int IdEvolucao { get; set; }
        public int IdPaciente { get; set; }
        public Paciente Paciente { get; set; }
        public DateTime DataAtividade { get; set; }
        public string? Aparelho { get; set; }
        public string? Anotacoes { get; set; }
        public string? ClienteChegou { get; set; }
        public string? ClienteSaiu { get; set; }
        public string? Fisioterapeuta { get; set; }

    }
}
