using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLib
{
    public static class GlobalConfig
    {
        public static List<IDataConn> Connections { get; private set; }
        public static void InitializeConns(bool database, bool textFiles)
        {
            if (database)
            {
                // TODO - create sql conn
            }
            if (textFiles)
            {
                // TODO - create txt conn
            }
        }
    }
}
