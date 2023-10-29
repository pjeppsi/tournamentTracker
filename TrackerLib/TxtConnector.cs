using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
