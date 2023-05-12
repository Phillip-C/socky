using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    static public class SocketHistory
    {
        static SocketHistory()
        {
            History = new List<SocketRecord>();
        }

        public struct SocketRecord
        {
            public int id;
            public string client;
            public string server;
        }
        public static List<SocketRecord> History;
    }
}
