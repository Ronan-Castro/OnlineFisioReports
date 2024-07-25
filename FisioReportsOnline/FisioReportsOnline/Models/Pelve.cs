namespace FisioReportsOnline.Models
{
    public class Pelve
    {
        public int IdPelve { get; set; }

        public int IdExameFisico { get; set; }
        public ExameFisico ExameFisico { get; set; }

        public bool IsNormal { get; set; } = false;
        public bool IsAnteversao { get; set; } = false;
        public bool IsRetroversao { get; set; } = false;
        public bool IsElevadoDireita { get; set; } = false;
        public bool IsElevadoEsquerda { get; set; } = false;
        public bool IsEscoliose { get; set; } = false;
    }
}