using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLib.Models;

namespace TrackerLib.Interfaces
{
    public interface IDataRepository
    {
        NagradaModel CreateNagradaModel(NagradaModel model);
    }
}
