﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ApiHabladores.Models.Riopos
{
    public partial class ConceptoArqueo
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Abreviatura { get; set; }
        public int Signo { get; set; }
        public string CodigoMoneda { get; set; }
    }
}
