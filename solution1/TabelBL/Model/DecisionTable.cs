﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabelBL.Model
{
    public class DecisionTable // 3 kol variable, rij variable
    {
        public string Naam { get; set; }
        public string DataType { get; set; }
        public int AantalKolommen { get; set; }
        public int AantalRijen { get; set; }
    }
}
