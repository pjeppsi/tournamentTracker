﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLib.Models
{
    public class NagradaModel
    {
        public int id { get; set; }
        public int Plasman { get; set; }
        public string PlasmanNaziv { get; set; }
        public decimal IznosNagrade { get; set; }
        public double PostotakNagrade { get; set; }
    }
}
