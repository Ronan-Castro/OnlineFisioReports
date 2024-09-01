using System.ComponentModel.DataAnnotations;
using LibFisioOnline.Models;

namespace FisioOnlineReports.Client.Pages.Pacientes
{
    public class PacienteInputModel
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
        public ComoConheceu ComoConheceu { get; set; }
        public int PacienteIndicouId { get; set; }
        public Paciente? PacienteIndicou { get; set; }

        [Required(ErrorMessage = "Data de nascimento deve ser fornecida")]
        public DateTime DataNascimento { get; set; }
        public DateTime UltimaDataAtendimento { get; set; }
    }

    public enum ComoConheceu
    {
        Google = 0,
        Facebook = 1,
        Instagram = 2,
        Localizacao = 3,
        Planos = 4,
        Convenios = 5,
        Indicacao = 6
    }
}
