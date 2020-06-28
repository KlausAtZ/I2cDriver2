using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I2cDriver2
{
    class I2cDriverDef
    {
        // Serial Com
        public static readonly int BaudRate = 1000000;
        public static readonly string Parity = "None";
        public static readonly int DataBits = 8;
        public static readonly string StopBits = "One";
        public static readonly string Handshake = "None";
        public static readonly int ReadTimeOut = 1000;
        public static readonly int WriteTimeOut = 1000;

    }
}

