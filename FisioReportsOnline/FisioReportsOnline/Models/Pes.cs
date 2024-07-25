namespace FisioReportsOnline.Models
{
    public class Pes
    {
        public int IdPes { get; set; }

        public int IdExameFisico { get; set; }
        public ExameFisico ExameFisico { get; set; }

        public bool IsNormal { get; set; } = false;
        public bool IsValgo { get; set; } = false;
        public bool IsVaro { get; set; } = false;
    }
}