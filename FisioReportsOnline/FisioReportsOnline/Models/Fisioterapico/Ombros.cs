namespace FisioReportsOnline.Models.Fisioterapico
{
    public class Ombros
    {
        public int IdOmbros { get; set; }

        public int IdExameFisico { get; set; }
        public ExameFisico ExameFisico { get; set; }

        public bool IsNormal { get; set; }
        public bool IsAnteriorizada { get; set; }
        public bool IsElevadoDireito { get; set; }
        public bool IsElevadoEsquerdo { get; set; }
        public bool IsEscapulaAlada { get; set; }
    }
}