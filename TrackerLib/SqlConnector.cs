﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLib
{
    public class SqlConnector : IDataConn
    {
        public NagradaModel CreateNagradaModel(NagradaModel model)
        {
            model.id = 1;
            return model;
            //throw new NotImplementedException();

        }
    }
}
