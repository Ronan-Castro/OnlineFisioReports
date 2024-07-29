using FisioReportsOnline.Models.Fisioterapico.ComposicaoExameFisico.Enum;
using FisioReportsOnline.Models.Fisioterapico.ExameFisico.Enum;

namespace FisioReportsOnline.Models.Fisioterapico.ComposicaoExameFisico
{
    public class Ombros
    {
        public int IdOmbros { get; set; }

        public int IdExameFisico { get; set; }
        public ExameFisico ExameFisico { get; set; }

        public bool IsNormal { get; set; }
        public bool IsAnteriorizada { get; set; }
        public LadoElevado LadoElevado { get; set; }
        public bool IsEscapulaAlada { get; set; }
    }
}