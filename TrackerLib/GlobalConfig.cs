using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLib
{
    public static class GlobalConfig
    {
        public static List<IDataConn> Connections { get; private set; } = new List<IDataConn>();
        public static void InitializeConns(bool database, bool textFiles)
        {
            if (database)
            {
                // TODO - create sql conn
                SqlConnector sqlConn = new SqlConnector();
                Connections.Add(sqlConn);
            }
            if (textFiles)
            {
                // TODO - create txt conn
                TxtConnector textConn = new TxtConnector();
                Connections.Add(textConn);
                
            }
        }
    }
}
