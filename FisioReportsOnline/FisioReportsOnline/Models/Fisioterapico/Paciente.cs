using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisioReportsOnline.Models.Fisioterapico
{
    public class Paciente
    {
        public int IdPaciente { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string Profissao { get; set; }
        public DateTime DataUltimaAvaliacao { get; set; }
        public DateTime DataUltimaAtividade { get; set; }
        public Sexo Sexo { get; set; }
        public Endereco Endereco { get; set; }

        //Usando ICollection para suportar lazy loading que o EF utiliza.
        public ICollection<Avaliacao> Avaliacoes { get; internal set; }
        public ICollection<Evolucao> Evolucoes { get; internal set; }
    }

    public enum Sexo
    {
        Masculino=0,
        Feminino=1
    }
}
