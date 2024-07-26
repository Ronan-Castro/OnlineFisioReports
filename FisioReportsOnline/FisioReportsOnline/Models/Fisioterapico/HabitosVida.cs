namespace FisioReportsOnline.Models.Fisioterapico
{
    public class HabitosVida
    {
        public int IdHabitosVida { get; set; }

        public int IdAvaliacao { get; set; }
        public Avaliacao Avaliacao { get; set; }

        public bool Tabagismo { get; set; } = false;
        public bool Etilismo { get; set; } = false;
        public bool IngereAgua { get; set; } = false;
        public bool Medicacao { get; set; } = false;
        public bool Intestino { get; set; } = false;
        public bool AtivFisica { get; set; } = false;
        public bool Pilates { get; set; } = false;
        public string? ObsHabitos { get; set; }
    }
}