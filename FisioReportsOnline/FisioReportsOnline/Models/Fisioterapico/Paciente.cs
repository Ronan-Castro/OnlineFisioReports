using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisioReportsOnline.Models.Fisioterapico
{
    public class Paciente
    {
        public int PacienteId { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string Profissao { get; set; }
        public DateTime DataUltimaAvaliacao { get; set; }
        public DateTime DataUltimaAtividade { get; set; }
        public string Sexo { get; set; }
        public string Endereco { get; set; }

        //Usando ICollection para suportar lazy loading que o EF utiliza.
        public ICollection<Avaliacao> Avaliacoes { get; internal set; }
        public ICollection<Evolucao> Evolucoes { get; internal set; }
    }
}
