using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLib.Models
{
    public class FazaNatjecanjaModel
    {
        public List<UparivanjeUnosModel> UnosPara { get; set; } = new List<UparivanjeUnosModel>();
        public TimModel Pobjednik { get; set; }
        public int Runda { get; set; }
    }
}
