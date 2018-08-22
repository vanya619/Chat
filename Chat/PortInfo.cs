using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat
{
    static class PortInfo
    {
        public static int BaudRate { get; set; }
        public static int DataBits { get; set; }
        public static string PortName { get; set; }
        public static int TimeRead { get; set; }
        public static int TimeWrite { get; set; }
        public static Encoding Encoding { get; set; }
    }
}
