namespace FisioReportsOnline.Models.Fisioterapico
{
    public class CabecaMap
    {
        public int IdCabeca { get; set; }

        public int IdExameFisico { get; set; }
        public ExameFisico ExameFisico { get; set; }

        public bool IsNormal { get; set; } = false;
        public bool IsInclinadaEsquerda { get; set; } = false;
        public bool IsInclinadaDireita { get; set; } = false;
    }
}