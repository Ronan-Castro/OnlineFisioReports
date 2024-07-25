namespace FisioReportsOnline.Models
{
    public class Joelhos
    {
        public int IdJoelhos { get; set; }

        public int IdExameFisico { get; set; }
        public ExameFisico ExameFisico { get; set; }

        public bool IsNormal { get; set; }
        public bool IsValgo { get; set; }
        public bool IsVaro { get; set; }
    }
}