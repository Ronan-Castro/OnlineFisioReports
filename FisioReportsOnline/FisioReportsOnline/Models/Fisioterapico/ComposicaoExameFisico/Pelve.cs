﻿using FisioReportsOnline.Models.Fisioterapico.ComposicaoExameFisico.Enum;

namespace FisioReportsOnline.Models.Fisioterapico.ComposicaoExameFisico
{
    public class Pelve
    {
        public int IdPelve { get; set; }
        public int IdExameFisico { get; set; }
        public bool IsNormal { get; set; } = false;
        public bool IsAnteversao { get; set; } = false;
        public bool IsRetroversao { get; set; } = false;
        public LadoElevado LadoElevado { get; set; }
        public bool IsEscoliose { get; set; } = false;
    }
}