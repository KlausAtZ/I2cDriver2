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

        // Requests
        public static readonly UInt16 FwVersion = 15;
        public static readonly UInt16 HwVersion = 16;
        public static readonly UInt16 SerialNumber = 17;
        public static readonly UInt16 ModuleNumber = 18;

        // Diagnostics
        public static readonly UInt16 CpuRev = 186;
        public static readonly UInt16 CpuFuses = 187;
        public static readonly UInt16 Coldstart = 197;
        public static readonly UInt16 Warmstart = 193;
        public static readonly UInt16 GetError = 95;
        public static readonly UInt16 ClrErrorLog = 94;
        public static readonly UInt16 GetVariable = 99;
        public static readonly UInt16 SetVariable = 98;
        public static readonly UInt16 SetPwrOn = 215;
        public static readonly UInt16 SetPwrOff = 216;

        // Update
        public static readonly Byte StartUpdate = 216;
        public static readonly Byte UpdWriteSect = 217;
        public static readonly Byte LOADER = 2;
        public static readonly Byte COMM = 3;
        public static readonly Byte APPLICATION = 1;
        public static readonly Byte FIRSTSECTOR = 16;
        public static readonly Byte LASTSECTOR = 17;
        public static readonly UInt32 LOADERSIZE = 0x2a80;
        public static readonly UInt32 COMMSIZE = 0x2280;
        public static readonly UInt32 APPLSIZE = 0x2a80;
        public static readonly UInt32 COMMBASEADDR = 0x2c00;
        public static readonly UInt32 APPLBASEADDR = 0x200;
        public static readonly UInt32 FIRSTBASEADDR = 0x00;
        public static readonly UInt32 LASTBASEADDR = 0x4f00;
        public static readonly UInt32 LOADBASEADDR = 0x200;
        public static readonly UInt32 FIRSTSECSIZE = 0x280;
        public static readonly UInt32 LASTSECSIZE = 0x180;
        public static readonly Byte VAR_UPDMEMTYPE = 114;
        public static readonly Byte VAR_SECTORDATA = 116;
        public static readonly Byte VAR_UPDERRNUM = 122;
        public static readonly Byte VAR_UPDERROR = 123;
        public static readonly Byte VAR_UPDVERS = 125;
        public static readonly Byte VAR_UPDSECVERS = 94;
        public static readonly Byte FUNCTION_SET1 = 0x40;
        public static readonly Byte FUNCTION_SET2 = 0x48;
        public static readonly Byte UPD_RQVAR = 0xc4;
        public static readonly Byte UPD_WRVAR = 0x44;
        public static readonly Byte UPD_COLDST = 0xc5;
        public static readonly Byte CLRERR = 0xc2;
        public static readonly Byte CLRERRLOG = 0x5e;

        public static readonly Byte VAR_UPDFLASH = 110;
        public static readonly Byte VAR_UPDRAM = 112;
        public static readonly Byte VAR_UPDEEPROM = 121;
        public static readonly Byte VAR_UPDADDR = 113;
        public static readonly Byte VAR_UPDLENGTH = 117;
        public static readonly Byte VAR_UPDKEY = 118;
        public static readonly Byte VAR_UPDDUMMY = 97;

        // Application
        public static readonly Byte RQVAR = 0xc0;
        public static readonly Byte WRVAR = 0x40;
        public static readonly Byte VAR_ERRNUM = 0;
        public static readonly Byte VAR_COMMERR = 1;
        public static readonly Byte VAR_RESETSTAT = 2;
        public static readonly Byte VAR_PRODDATA = 4;
        public static readonly Byte VAR_VERS = 7;
        public static readonly Byte VAR_VERSDATE = 8;
        public static readonly Byte VAR_SERNUM = 9;
        public static readonly Byte VAR_SERNUM2 = 98;
        public static readonly Byte VAR_HWVERS = 95;

        // ----------------
        public static readonly Byte I2C_ACTION_TIMEOUT = 9;
    }
}

