using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Sockets;
using System.Threading;
namespace ChinaBlock
{
    class RBsocket
    {
        private string IP;
        private int port;
        private Socket socket;
        private Thread thread_rec;
        private string tag = "error from RBsocket\n";
        public RBsocket(string ip, int port)
        {

            this.IP = ip;
            this.port = port;
            try
            {
                IPEndPoint point = new IPEndPoint(IPAddress.Parse(ip), port);

                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                socket.Connect(point);

                thread_rec = new Thread(new ThreadStart(Rec));
                thread_rec.IsBackground = true;
                thread_rec.Start();

            }
            catch(Exception e)
            {
                Console.WriteLine(tag + e.ToString());
            }
       
        }


        public void Rec()
        {
            while (true)
            {
                string rec_msg;
                byte[] msg = new byte[1024 * 1024 * 4];//4MB
                try
                {
                    int length = socket.Receive(msg);
                    rec_msg = Encoding.UTF8.GetString(msg, 0, length);

                    //TODO:回调函数
                    Global.callback(rec_msg);
                    //用#号隔开
                    Send(Global.posClient_callback());
                    
                }
                catch (Exception e)
                {

                    Console.WriteLine(tag + e.ToString());
                }

                
            }
            
        }

        public void Send(string str)
        {
            if (socket.Connected)
            {
                try
                {
                    socket.Send(Encoding.UTF8.GetBytes(str));
                }catch (Exception e)
                {
                    Console.WriteLine(tag + e.ToString());
                }
            }
            else
            {
                Console.WriteLine(tag + "socket is not connected");
            }
        }
    }
}
