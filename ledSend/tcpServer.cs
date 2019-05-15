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
    public class tcpServer
    {
        public string ip;
        public string port;
        public RichTextBox txtMsg;
        TcpRevEventHandler _eventRev;
        public tcpServer(RichTextBox richrichTextBox, TcpRevEventHandler tcpevent)
        {
            txtMsg = richrichTextBox;
            ip = GetLocalIP();
            port = "8900";
            setServerListten();
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
        // 创建一个和客户端通信的套接字
        static Socket socketwatch = null;
        //定义一个集合，存储客户端信息
        static Dictionary<string, Socket> clientConnectionItems = new Dictionary<string, Socket> { };
        static Dictionary<string, Socket> numclientConnect = new Dictionary<string, Socket> { };

        public void setServerListten()
        {
            //定义一个套接字用于监听客户端发来的消息，包含三个参数（IP4寻址协议，流式连接，Tcp协议）  
            socketwatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //服务端发送信息需要一个IP地址和端口号  
            IPAddress address = IPAddress.Parse(ip);
            //将IP地址和端口号绑定到网络节点point上  
            IPEndPoint point = new IPEndPoint(address, 9999);
            //此端口专门用来监听的  

            //监听绑定的网络节点  
            socketwatch.Bind(point);

            //将套接字的监听队列长度限制为20  
            socketwatch.Listen(20);

            //负责监听客户端的线程:创建一个监听线程  
            Thread threadwatch = new Thread(watchconnecting);

            //将窗体线程设置为与后台同步，随着主线程结束而结束  
            threadwatch.IsBackground = true;

            //启动线程     
            threadwatch.Start();
        }

        //监听客户端发来的请求  
        public void watchconnecting()
        {
            Socket connection = null;

            //持续不断监听客户端发来的请求     
            while (true)
            {
                try
                {
                    connection = socketwatch.Accept();
                }
                catch (Exception ex)
                {
                    //提示套接字监听异常     
                    txtMsg.AppendText(ex.Message);
                    break;
                }

                //获取客户端的IP和端口号  
                IPAddress clientIP = (connection.RemoteEndPoint as IPEndPoint).Address;
                int clientPort = (connection.RemoteEndPoint as IPEndPoint).Port;

                //让客户显示"连接成功的"的信息  
                //string sendmsg = "连接服务端成功！\r\n" + "本地IP:" + clientIP + "，本地端口" + clientPort.ToString();
                //byte[] arrSendMsg = Encoding.UTF8.GetBytes(sendmsg);
                //connection.Send(arrSendMsg);                
                //客户端网络结点号  
                string remoteEndPoint = connection.RemoteEndPoint.ToString();
                //显示与客户端连接情况
                //txtMsg.AppendText("成功与" + remoteEndPoint + "客户端建立连接！\t\n");
                //添加客户端信息  
                clientConnectionItems.Add(remoteEndPoint, connection);

                //IPEndPoint netpoint = new IPEndPoint(clientIP,clientPort); 
                IPEndPoint netpoint = connection.RemoteEndPoint as IPEndPoint;

                //创建一个通信线程      
                ParameterizedThreadStart pts = new ParameterizedThreadStart(recv);
                Thread thread = new Thread(pts);
                //设置为后台线程，随着主线程退出而退出 
                thread.IsBackground = true;
                //启动线程     
                thread.Start(connection);
            }
        }

        /// <summary>
        /// 接收客户端发来的信息，客户端套接字对象
        /// </summary>
        /// <param name="socketclientpara"></param>    
        public void recv(object socketclientpara)
        {
            Socket socketServer = socketclientpara as Socket;

            while (true)
            {
                //创建一个内存缓冲区，其大小为1024*1024字节  即1M     
                byte[] arrServerRecMsg = new byte[1024 * 1024];
                //将接收到的信息存入到内存缓冲区，并返回其字节数组的长度    
                try
                {
                    int length = socketServer.Receive(arrServerRecMsg);

                    //将机器接受到的字节数组转换为人可以读懂的字符串     
                    string strSRecMsg = Encoding.UTF8.GetString(arrServerRecMsg, 0, length);
                    string num = _eventRev(strSRecMsg);
                    try
                    {
                        if (Convert.ToInt32(num) < 4)
                        {
                            numclientConnect.Add(num, socketServer);
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }

                    //将发送的字符串信息附加到文本框txtMsg上     
                    //txtMsg.AppendText("客户端:" + socketServer.RemoteEndPoint + ",time:" + GetCurrentTime() + "\r\n" + strSRecMsg + "\r\n\n");

                    //socketServer.Send(Encoding.UTF8.GetBytes("测试server 是否可以发送数据给client "));
                }
                catch (Exception ex)
                {
                    clientConnectionItems.Remove(socketServer.RemoteEndPoint.ToString());

                    //txtMsg.AppendText("Client Count:" + clientConnectionItems.Count);

                    //提示套接字监听异常  
                    //txtMsg.AppendText("客户端" + socketServer.RemoteEndPoint + "已经中断连接" + "\r\n" + ex.Message + "\r\n" + ex.StackTrace + "\r\n");
                    //关闭之前accept出来的和客户端进行通信的套接字 
                    socketServer.Close();
                    break;
                }
            }
        }
        public void sendMessage(string str,int num)
        {
            foreach(var key in numclientConnect.Keys)
            {
                if(key == num.ToString())
                {
                    numclientConnect[num.ToString()].Send(Encoding.UTF8.GetBytes(str));
                }
            }
        }
        ///      
        /// 获取当前系统时间的方法    
        /// 当前时间     
        public DateTime GetCurrentTime()
        {
            DateTime currentTime = new DateTime();
            currentTime = DateTime.Now;
            return currentTime;
        }
    }
}
