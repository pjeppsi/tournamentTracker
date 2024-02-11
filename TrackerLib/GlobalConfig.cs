using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLib.Interfaces;
using TrackerLib.Repository;

namespace TrackerLib
{
    public static class GlobalConfig
    {
        public static List<IDataRepository> Connections { get; private set; } = new List<IDataRepository>();
        public static void InitializeConns(bool database, bool textFiles)
        {
            if (database)
            {
                SqlConnector sqlConn = new SqlConnector();
                Connections.Add(sqlConn);
            }
            if (textFiles)
            {
                TxtConnector textConn = new TxtConnector();
                Connections.Add(textConn);
            }
        }
    }
}
