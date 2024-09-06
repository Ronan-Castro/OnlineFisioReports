using System.ComponentModel.DataAnnotations;

namespace FisioOnlineReports.Client.Pages.TabelaProcedimento
{
    public class TabelaProcedimentoInputModel
    {

        [Required(ErrorMessage = "Nome deve ser fornecido")]
        [MaxLength(50, ErrorMessage = "{0} deve ter no máximo {1} caracteres")]
        public string Nome { get; set; } = null!;

    }
   
}
