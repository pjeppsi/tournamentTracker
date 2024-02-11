using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLib.Interfaces;
using TrackerLib.Models;

namespace TrackerLib
{
    public class TxtConnector : IDataConn
    {
        public NagradaModel CreateNagradaModel(NagradaModel model)
        {
            model.id = 1;
            return model;
        }
    }
}
