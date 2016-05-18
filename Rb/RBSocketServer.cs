using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace ChinaBlock
{
    class RBSocketServer
    {
        public IPAddress ip;
        public int port;
        public Socket server;
        public string tag = "error from rbsocketsercer\n";
        private Thread thread_accept;
        private Thread thread_rec;

        private Socket current;//仅支持一对一服务器
        public RBSocketServer(string Ip, int Port)
        {
            try
            {
                this.ip = IPAddress.Parse(Ip);
                this.port = Port;
                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                server.Bind(new IPEndPoint(this.ip, port));
                server.Listen(10);

                thread_accept = new Thread(new ThreadStart(Watching));
                thread_accept.IsBackground = true;
                thread_accept.Start();
            } catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            
        }

        private void Watching()
        {
            while (true)
            {
                //服务端收到消息之后可以返回消息
                current = server.Accept();
                try
                {
                    thread_rec = new Thread(new ThreadStart(Rec));
                    thread_rec.IsBackground = true;
                    thread_rec.Start();
                    ////TODO:回调函数
                    //Global.server_callback(rec_msg);//收到的消息
                    //socket.Send(Encoding.UTF8.GetBytes( Global.pos_callback() ));//返回的消息
                }
                catch (Exception e)
                {

                    Console.WriteLine(tag + e.ToString());
                }
            }

        }
        private void Rec()
        {
            while (true)
            {
                string rec_msg;
                byte[] msg = new byte[1024 * 1024 * 4];//4MB
                try
                {
                    int length = current.Receive(msg);
                    rec_msg = Encoding.UTF8.GetString(msg, 0, length);

                    //TODO:回调函数
                    Global.server_callback(rec_msg);//收到的消息
                    current.Send(Encoding.UTF8.GetBytes(Global.pos_callback()));//返回的消息
                }
                catch (Exception e)
                {

                    Console.WriteLine(tag + e.ToString());
                }
            }
        }

    }
}
