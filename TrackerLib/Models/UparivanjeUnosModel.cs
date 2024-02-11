using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLib.Models
{
    public class UparivanjeUnosModel
    {
        public TimModel NatjecateljskiTim { get; set; }
        public double Rezultat { get; set; }

        public FazaNatjecanjaModel ParentUparivanje { get; set; }

    }
}
