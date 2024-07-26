using System.ComponentModel.DataAnnotations.Schema;

namespace FisioReportsOnline.Models.Fisioterapico
{
    public class PadraoMovimento
    {
        public int IdPadraoMovimento { get; set; }

        public int IdExameFisico { get; set; }
        public ExameFisico ExameFisico { get; set; }

        public bool IsRigido { get; set; } = false;
        public bool IsMaleavel { get; set; } = false;

    }
}