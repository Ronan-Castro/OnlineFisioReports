using FisioReportsOnline.Models.Fisioterapico.ComposicaoExameFisico.Enum;

namespace FisioReportsOnline.Models.Fisioterapico.ComposicaoExameFisico
{
    public class Ombro
    {
        public int IdOmbros { get; set; }
        public int IdExameFisico { get; set; }
        public bool IsNormal { get; set; }
        public bool IsAnteriorizada { get; set; }
        public LadoElevado LadoElevado { get; set; }
        public bool IsEscapulaAlada { get; set; }
    }
}