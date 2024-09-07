using System.ComponentModel.DataAnnotations;
using FisioOnlineReports.Client.Pages.Procedimento;
using LibFisioOnline.Models;

namespace FisioOnlineReports.Client.Pages.Orcamentos
{
    public class OrcamentoInputModel
    {

        [Required(ErrorMessage = "Valor deve ser fornecido")]
        public decimal ValorTotal { get; set; }
        public decimal Desconto { get; set; }
        public int UsuarioId { get; set; }
        public int PacienteId { get; set; }
        public int TabelaId { get; set; }
        public List<ProcedimentoInputModel> Procedimentos { get; set; } = new List<ProcedimentoInputModel>();

    }
}
