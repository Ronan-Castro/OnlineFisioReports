using System.ComponentModel.DataAnnotations;
using LibFisioOnline.Models;

namespace FisioOnlineReports.Client.Pages.Usuarios
{
    public class UsuarioInputModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome deve ser fornecido")]
        [MaxLength(50, ErrorMessage = "{0} deve ter no máximo {1} caracteres")]
        public string Nome { get; set; } = null!;

        [Required(ErrorMessage = "Documento deve ser fornecido")]
        public string Documento { get; set; } = null!;

        [Required(ErrorMessage = "E-mail deve ser fornecido")]
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        [MaxLength(50, ErrorMessage = "{0} deve ter no máximo {1} caracteres")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Celular deve ser fornecido")]
        public string Celular { get; set; } = null!;

        [Required(ErrorMessage = "Data de nascimento deve ser fornecida")]
        public DateTime DataNascimento { get; set; }

        public bool IsGerente { get; set; }
        public bool IsAtendente { get; set; }

        //caso seja profissionalSaude
        public bool IsProfissionalSaude { get; set; }
        public string DocumentoProfissional { get; set; } = null!;
        public int EspecialidadeId { get; set; }
        public TipoProfissional TipoProfissional { get; set; }
    }
   
}
