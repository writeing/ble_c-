using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ledSend
{
    public class deviceInfo
    {
        public int localNum;
        public int revCount;
        public int sendCount;

        public int[] sendObj = new int[3];
        //send 
        public const bool SEND_CMD = false;
        public const bool SEND_DATA = true;
        public string sendFilePath;
        public string sendFileSize;
        public string sendFileType;
        public bool sendFileEncrypt;
        public string sendfileName;
        public bool sendMode;
        public string saveFilePath;
        public bool revFileDecrypt;

        //rev 
        public const bool CMD_MODE = true;
        public const bool DATA_MODE = false;

        public const bool REV_ING = true;
        public const bool REV_FINISH = false;
        public int revSize;
        public string revType;
        public string revFileName;
        public string revNum;
        public bool revMode;
        public bool revStatus;
        //status 
        public bool SerialConnectStatus;
        public bool sendFileStatus;
        public bool devStatus;       
    }
}
