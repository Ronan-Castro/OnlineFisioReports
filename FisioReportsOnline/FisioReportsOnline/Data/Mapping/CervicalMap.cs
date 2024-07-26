namespace FisioReportsOnline.Models.Fisioterapico
{
    public class CervicalMap
    {
        public int IdCervical { get; set; }

        public int IdExameFisico { get; set; }
        public ExameFisico ExameFisico { get; set; }

        public bool IsNormal { get; set; } = false;
        public bool IsAnteriorizada { get; set; } = false;
        public bool IsRetificada { get; set; } = false;
    }
}