using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisioReportsOnline.Models.Fisioterapico
{
    public class DoencaCondicao
    {
        public int IdDoencasCondicoes { get; set; }
        public int IdAvaliacao { get; set; }

        public bool Metabolica { get; set; } = false;
        public bool Cardiaca { get; set; } = false;
        public bool Respiratorias { get; set; } = false;
        public bool Vasculares { get; set; } = false;
        public bool Neurologicas { get; set; } = false;
        public bool Endocrina { get; set; } = false;
        public bool Dermatologica { get; set; } = false;
        public bool GastroIntestinal { get; set; } = false;
        public bool Visual { get; set; } = false;
        public bool Covid { get; set; } = false;
        public bool Diabete { get; set; } = false;
        public bool Hipertensao { get; set; } = false;
        public bool Cardiopatia { get; set; } = false;
        public bool Neoplasias { get; set; } = false;
        public bool DoencasHereditarias { get; set; } = false;
        public bool Gestacao { get; set; } = false;
        public bool Cirurgias { get; set; } = false;
    }
}
