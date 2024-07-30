using FisioReportsOnline.Models.Fisioterapico;

namespace FisioReportsOnline.Models
{
    public class Endereco
    {
        public int IdEndereco { get; set; }
        public int IdPaciente { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int Numero { get; set; }
    }
}
