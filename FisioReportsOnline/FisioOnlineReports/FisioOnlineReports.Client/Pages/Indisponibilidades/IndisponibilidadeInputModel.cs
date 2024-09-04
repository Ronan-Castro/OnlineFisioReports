using System.ComponentModel.DataAnnotations;

namespace FisioOnlineReports.Client.Pages.Indisponibilidades
{
    public class IndisponibilidadeInputModel
    {
        [Required(ErrorMessage = "Nome deve ser fornecido")]
        [MaxLength(250, ErrorMessage = "{0} deve ter no máximo {1} caracteres")]
        public string Motivo { get; set; } = null!;
        public DateTime InicioIndisponibilidade { get; set; } = DateTime.Now;
        public DateTime FimIndisponibilidade { get; set; } = DateTime.Now;
        public int AmbienteId { get; set; }
    }
}