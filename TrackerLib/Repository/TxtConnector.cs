using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLib.Interfaces;
using TrackerLib.Models;

namespace TrackerLib.Repository
{
    public class TxtConnector : IDataRepository
    {
        public NagradaModel CreateNagradaModel(NagradaModel model)
        {
            model.id = 1;
            return model;
        }
    }
}
