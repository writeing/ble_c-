using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ledSend
{
    public class tcpClient
    {
        //创建 1个客户端套接字 和1个负责监听服务端请求的线程  
        Thread threadclient = null;
        Socket socketclient = null;
        public string serIp;
        public int serport = 9999;
        public RichTextBox txtMesg;
        TcpRevEventHandler _eventRev;
        public tcpClient(RichTextBox richrichTextBox, TcpRevEventHandler tcpevent ,string _serIp = "127.0.0.1")
        {
            if (_serIp == "127.0.0.1")
            {
                serIp = GetLocalIP();
            }
            else
            {
                serIp = _serIp;
            }
            txtMesg = richrichTextBox;
            settcpClient();
            _eventRev = tcpevent;
        }
        /// <summary>
        /// 获取本机IP地址
        /// </summary>
        /// <returns>本机IP地址</returns>
        public string GetLocalIP()
        {
            try
            {
                string HostName = Dns.GetHostName(); //得到主机名
                IPHostEntry IpEntry = Dns.GetHostEntry(HostName);
                for (int i = 0; i < IpEntry.AddressList.Length; i++)
                {
                    //从IP地址列表中筛选出IPv4类型的IP地址
                    //AddressFamily.InterNetwork表示此IP为IPv4,
                    //AddressFamily.InterNetworkV6表示此地址为IPv6类型
                    if (IpEntry.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
                    {
                        return IpEntry.AddressList[i].ToString();
                    }
                }
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        private void settcpClient()
        {
            //定义一个套接字监听  
            socketclient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            //获取文本框中的IP地址  
            IPAddress address = IPAddress.Parse(serIp);

            //将获取的IP地址和端口号绑定在网络节点上  
            IPEndPoint point = new IPEndPoint(address, serport);

            try
            {
                //客户端套接字连接到网络节点上，用的是Connect  
                socketclient.Connect(point);
            }
            catch (Exception)
            {
                txtMesg.AppendText("连接失败\r\n");               

                //this.txtDebugInfo.AppendText("连接失败\r\n");
                return;
            }

            threadclient = new Thread(recv);
            threadclient.IsBackground = true;
            threadclient.Start();
        }

        // 接收服务端发来信息的方法    
        void recv()
        {
            int x = 0;
            //持续监听服务端发来的消息 
            while (true)
            {
                try
                {
                    //定义一个1M的内存缓冲区，用于临时性存储接收到的消息  
                    byte[] arrRecvmsg = new byte[1024 * 1024];

                    //将客户端套接字接收到的数据存入内存缓冲区，并获取长度  
                    int length = socketclient.Receive(arrRecvmsg);

                    //将套接字获取到的字符数组转换为人可以看懂的字符串  
                            
                    _eventRev(arrRecvmsg, length);
                }
                catch (Exception ex)
                {
                    this.txtMesg.AppendText("远程服务器已经中断连接" + "\r\n\n");
                    break;
                }
            }
        }

        //获取当前系统时间  
        DateTime GetCurrentTime()
        {
            DateTime currentTime = new DateTime();
            currentTime = DateTime.Now;
            return currentTime;
        }

        //发送字符信息到服务端的方法  
        public void ClientSendMsg(byte[] sendMsg)
        {
            //将输入的内容字符串转换为机器可以识别的字节数组     
            //byte[] arrClientSendMsg = Encoding.UTF8.GetBytes(sendMsg);
            //调用客户端套接字发送字节数组     
            socketclient.Send(sendMsg);
            //将发送的信息追加到聊天内容文本框中     
            //this.txtMesg.AppendText(sendMsg + "\r\n");            
        }
    }
}
