using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLib
{
    public class NatjecanjeModel
    {
        public string ImeTurnira { get; set; }
        public decimal Kotizacija { get; set; }

        public List<TimModel> PrijavljeniTimovi{ get; set; } = new List<TimModel>();
        public List<NagradaModel> Nagrade { get; set; } = new List<NagradaModel>();

        public List<List<FazaNatjecanjaModel>> FazaNatjecanja{ get; set; } = new List<List<FazaNatjecanjaModel>>();
    }
}
