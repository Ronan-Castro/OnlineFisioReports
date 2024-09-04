using System.ComponentModel.DataAnnotations;

namespace FisioOnlineReports.Client.Pages.Especialidades
{
    public class EspecialidadeInputModel
    {
        [Required(ErrorMessage = "Nome deve ser fornecido")]
        [MaxLength(50, ErrorMessage = "{0} deve ter no máximo {1} caracteres")]
        public string Nome { get; set; } = null!;

        [MaxLength(250, ErrorMessage = "{0} deve ter no máximo {1} caracteres")]
        public string? Descricao { get; set; } = null;
    }
}