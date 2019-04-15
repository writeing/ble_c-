﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ledSend
{
    public partial class Form1 : Form
    {

        public deviceInfo g_deviceInfo = new deviceInfo();
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// updata combox port info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbPort_Click(object sender, EventArgs e)
        {
            string[] names = SerialPort.GetPortNames();
            cmbPort.Items.Clear();
            try
            {
                cmbPort.Items.AddRange(names);
                cmbPort.SelectedIndex = 0;
            }
            catch (Exception)
            {                
            }
            
        }
        /// <summary>
        /// connect serial port
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnConnect.Text == "连接")
                {
                    serialPort1.PortName = cmbPort.Text;
                    serialPort1.Open();
                    btnConnect.Text = "关闭";
                    btnSeralStatus.BackColor = Color.Blue;
                    g_deviceInfo.SerialConnectStatus = true;
                }
                else if(btnConnect.Text == "关闭")
                {
                    serialPort1.Close();
                    btnConnect.Text = "连接";
                    btnSeralStatus.BackColor = Color.White;
                    g_deviceInfo.SerialConnectStatus = false;
                }
            }
            catch (Exception)
            {
                return;                
            }
            

        }
        public string g_revData = "";
        private void ansyRevData(byte[] revbuff,int len)
        {
            string str = g_revData + Encoding.Default.GetString(revbuff);
            int lastIndex = str.LastIndexOf(';');
            string strRevCmd = str.Substring(0, lastIndex);
            g_revData = str.Substring(lastIndex+1);
            string[] strcmdItems = strRevCmd.Split(';');
            foreach(string cmditme in strcmdItems)
            {
                string fileCmd = cmditme.Split(':')[0];
                string value = cmditme.Split(':')[1];
                if(fileCmd.Contains("fileName"))
                {
                    g_deviceInfo.revFileName = value;
                    rtbLog.AppendText("fileName:" + value + "\r\n");
                }
                if (fileCmd.Contains("fileSize"))
                {
                    g_deviceInfo.revSize =Convert.ToInt32(value);
                    rtbLog.AppendText("fileSize:" + value + "\r\n");
                }
                if (fileCmd.Contains("fileType"))
                {
                    g_deviceInfo.revType = value;
                    rtbLog.AppendText("fileType:" + value + "\r\n");
                }
                if (fileCmd.Contains("fileNum"))
                {
                    g_deviceInfo.revNum = value;
                    g_deviceInfo.revMode = deviceInfo.DATA_MODE;
                    rtbLog.AppendText("fileNum:" + value + "\r\n");
                }
                if (fileCmd.Contains("deviceBengin"))
                {
                    if (value.Contains("1"))
                    {
                        g_deviceInfo.revMode = deviceInfo.DATA_MODE;
                    }
                    if (value.Contains("2"))
                    {
                        g_deviceInfo.sendMode = deviceInfo.SEND_DATA;
                    }

                    rtbLog.AppendText("deviceBengin:" + value + "\r\n");
                }
                if (fileCmd.Contains("bleStatus"))
                {
                    if(value == "0")
                        g_deviceInfo.devStatus = false;                    
                    else if (value == "1")
                        g_deviceInfo.devStatus = true;
                    rtbLog.AppendText("bleStatus:" + value + "\r\n");
                }

            }
        }
        public FileStream fs = null;
        public int revFileCount = 0;
        private bool saveDataToFile(byte[] buff,int len)
        {
            bool rpy = false;             
            fs.Write(buff, 0, len);
            revFileCount += len;
            if (revFileCount == g_deviceInfo.revSize)
                rpy = true;
            return rpy;
        }
        private void openWriteFile()
        {
            if (fs == null)
            {
                try
                {
                    fs = new FileStream(g_deviceInfo.saveFilePath + g_deviceInfo.revFileName + g_deviceInfo.revType, FileMode.OpenOrCreate);
                }
                catch (Exception)
                {
                    MessageBox.Show("save path is error");                    
                }
            }
                
        }
        private void closeWriteFile()
        {
            fs.Flush();
            fs.Close();
            fs = null;
            revFileCount = 0;
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                Control.CheckForIllegalCrossThreadCalls = false;
                int len = serialPort1.BytesToRead;
                g_deviceInfo.revCount += len;
                byte[] revBuff = new byte[len + 1];
                serialPort1.Read(revBuff, 0, len);
                if (g_deviceInfo.revMode == deviceInfo.CMD_MODE)
                {                    
                    ansyRevData(revBuff, len);
                }
                else
                {
                    openWriteFile();
                    //save data to file
                    bool ryp = saveDataToFile(revBuff, len);
                    //if rev finish 
                    if (ryp == true)
                    {
                        g_deviceInfo.revMode = deviceInfo.CMD_MODE;
                        closeWriteFile();
                        g_deviceInfo.revStatus = deviceInfo.REV_FINISH;                
                    }
                }

            }
            catch (Exception)
            {                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen && btnConnect.Text == "关闭")
            {
                btnSeralStatus.BackColor = Color.Red;
                btnConnect.Text = "连接";
                g_deviceInfo.SerialConnectStatus = false;
            }
            if(g_deviceInfo.revStatus == deviceInfo.REV_FINISH)
            {
                //show rev info
                tbRevNum.Text = g_deviceInfo.revNum;
                tbrevSize.Text = g_deviceInfo.revSize.ToString();
                tbrevType.Text = g_deviceInfo.revType;
                tbrevName.Text = g_deviceInfo.revFileName;
                g_deviceInfo.revStatus = deviceInfo.REV_ING;
            }
            btnSendCount.Text = g_deviceInfo.sendCount.ToString();
            btnRevCount.Text = g_deviceInfo.revCount.ToString();

            if(g_deviceInfo.devStatus)
            {
                btnBleStatus.BackColor = Color.Blue;
            }
            else
            {
                btnBleStatus.BackColor = Color.Red;
            }
        }
        /// <summary>
        /// 获取radio的选择项，确定设备编号
        /// </summary>
        /// <returns></returns>
        private int getRadioDeviceNum()
        {
            int i = 0;
            // 1 2 3 
            if (radioButton1.Checked)
                i = 1;
            if (radioButton2.Checked)
                i = 2;
            if (radioButton3.Checked)
                i = 3;
            return i;
        }

        /// <summary>
        /// open send file,,,get file path
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            FileDialog filed = new OpenFileDialog();
            if(filed.ShowDialog() == DialogResult.OK)
            {                
                string filePath = filed.FileNames[0];
                FileInfo fileinfo = new FileInfo(filePath);
                string fileExt = fileinfo.Extension;
                string filesize = fileinfo.Length.ToString();
                string fileName = fileinfo.Name;


                tbFileSize.Text = filesize;
                tbFileType.Text = fileExt;
                tbSendFile.Text = filePath;
                g_deviceInfo.sendfileName = fileName;
                g_deviceInfo.sendFileType = fileExt;
                g_deviceInfo.sendFileSize = filesize;
                g_deviceInfo.sendFilePath = filePath;
                g_deviceInfo.sendFileStatus = true;
            }
        }
        /// <summary>
        /// set svae file path
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath;
                tbSaveFile.Text = foldPath + "\\";
                g_deviceInfo.saveFilePath = tbSaveFile.Text;
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            g_deviceInfo.revCount = 0;
            g_deviceInfo.sendCount = 0;
            btnSendCount.Text = "0";
            btnRevCount.Text = "0";
        }
        /// <summary>
        /// get send obj for checkbox
        /// </summary>
        /// <returns></returns>
        private int[] getSendObj()
        {
            int[] _temp = new int[3] { 0,0,0};
            if (chbdev1.Checked)
                _temp[0] = 1;
            if (chbdev2.Checked)
                _temp[1] = 1;
            if (chbdev3.Checked)
                _temp[2] = 1;
            return _temp;
        }
        private void btnSendData_Click(object sender, EventArgs e)
        {
            g_deviceInfo.localNum = getRadioDeviceNum();
            g_deviceInfo.sendObj = getSendObj();
            sendDataToBle();
        }
        /// <summary>
        /// set send file Head info
        /// </summary>
        /// <returns></returns>
        private Dictionary<string, string> setSendHeadFifo()
        {
            Dictionary<string, string> g_listHead = new Dictionary<string, string>();
            g_listHead["fileName"] = g_deviceInfo.sendfileName;
            g_listHead["fileSize"] = g_deviceInfo.sendFileSize;
            g_listHead["fileType"] = g_deviceInfo.sendFileType;
            g_listHead["fileNum"] = g_deviceInfo.localNum.ToString();
            g_listHead["fileEncrypt"] = g_deviceInfo.sendFileEncrypt.ToString();
            string sendobj = "";
            for (int i = 0; i < 3; i++)
            {
                if (i + 1 == g_deviceInfo.localNum)
                {
                    continue;
                }
                if(g_deviceInfo.sendObj[i] == 1)
                sendobj += (i+1);                
            }
            g_listHead["FileObj"] = sendobj;
            return g_listHead;
        }
        /// <summary>
        /// get send file to string 
        /// </summary>
        /// <returns></returns>
        private byte[] getSendFile()
        {
            try
            {
                byte[] buff = File.ReadAllBytes(g_deviceInfo.sendFilePath);
                return buff;
            }
            catch (Exception)
            {
                return null;
            }                       
        }
        private void sendFileBuff(byte[] data)
        {
            int sendsize = Convert.ToInt32(g_deviceInfo.sendFileSize);
            int i = 0;
            for (i = 0; i < sendsize; i += 1024)
            {
                serialPort1.Write(data, i, 1024);
                Thread.Sleep(200);
                g_deviceInfo.sendCount += 1024;
            }
            serialPort1.Write(data, i, sendsize - i);
            g_deviceInfo.sendCount += sendsize - i;
        }
        /// <summary>
        /// send data with serial to device
        /// </summary>
        /// <param name="temp"></param>
        /// <param name="data"></param>
        private void _sendData(Dictionary<string, string> temp,byte[] data)
        {
            try
            {
                foreach (KeyValuePair<string, string> kv in temp)
                {
                    string sendbuff = kv.Key + ":" + kv.Value + ";";
                    serialPort1.Write(sendbuff);
                    Thread.Sleep(100);                           
                }
                while (g_deviceInfo.sendMode == deviceInfo.SEND_CMD)
                {
                    Thread.Sleep(100);
                }
                sendFileBuff(data);
                g_deviceInfo.sendMode = deviceInfo.SEND_CMD;
            }
            catch (Exception)
            {                
            }
        }
        private bool checkDeviceStatus()
        {
            if (g_deviceInfo.sendFileStatus && g_deviceInfo.SerialConnectStatus)
                return true;
            return false;
        }
        private void sendDataToBle()
        {
            //checkSendStatus
            if (!checkDeviceStatus())
            {
                rtbLog.AppendText("软件或者设备没有准备好\r\n");
                return;
            }
            //send head fifo
            Dictionary<string, string> temp = setSendHeadFifo();
            //read data
            byte[] sendData = getSendFile();
            //send data      
            _sendData(temp, sendData);
            rtbLog.AppendText("数据发送完成，发送数据长度:" + g_deviceInfo.sendCount.ToString() + "\r\n");
        }




        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chbEncrypt_CheckedChanged(object sender, EventArgs e)
        {
            g_deviceInfo.sendFileEncrypt = chbEncrypt.Checked;
        }

        private void chbDecrypt_CheckedChanged(object sender, EventArgs e)
        {
            g_deviceInfo.revFileDecrypt = chbDecrypt.Checked;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g_deviceInfo.revMode = deviceInfo.CMD_MODE;
            g_deviceInfo.revStatus = deviceInfo.REV_ING;
            g_deviceInfo.saveFilePath = tbSaveFile.Text;

            btnClean_Click(this, null);            

            timer1.Start();


        }
    }
}
