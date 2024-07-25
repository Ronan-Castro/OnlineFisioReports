using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisioReportsOnline.Models
{
    public class Avaliacao
    {
        public int IdAvaliacao { get; set; }

        public int IdPaciente { get; set; }
        public Paciente Paciente { get; set; }

        public string? DiagClinico { get; set; }
        public string? DiagFisioterapeutico { get; set; }
        public string? QueixaPrincipal { get; set; }
        public string? ObservacaoDoenca { get; set; }
        public string? TratamentoAnterior { get; set; }
        public string? ObjetivoTerapeutico { get; set; }
        public string? ObjetivoPessoal { get; set; }
        public DateTime DataAtendimento { get; set; }

        // Doenças e/ou Condições
        public DoencasCondicoes DoencasCondicoes { get; set; } = new();

        // Hábitos de Vida
        public HabitosVida HabitosVida { get; set; } = new();

        // Exame Físico
        public ExameFisico ExameFisico { get; set; } = new();


    }

}
