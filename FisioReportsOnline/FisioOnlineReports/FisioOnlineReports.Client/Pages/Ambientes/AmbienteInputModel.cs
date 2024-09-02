using System.ComponentModel.DataAnnotations;
using LibFisioOnline.Models;

namespace FisioOnlineReports.Client.Pages.Ambientes
{
    public class AmbienteInputModel
    {

        [Required(ErrorMessage = "Nome deve ser fornecido")]
        [MaxLength(50, ErrorMessage = "{0} deve ter no máximo {1} caracteres")]
        public string Nome { get; set; } = null!;

    }
   
}
