namespace FisioReportsOnline.Models.Fisioterapico
{
    public class ColunaMap

    {
        public int IdColuna { get; set; }

        public int IdExameFisico { get; set; }
        public ExameFisico ExameFisico { get; set; }

        public bool IsNormal { get; set; } = false;
        public bool IsEscoliose { get; set; } = false;
        public bool IsHipercifose { get; set; } = false;
        public bool IsHiperlordose { get; set; } = false;
    }
}