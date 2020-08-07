using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace WebSocket
{
    class Server
    {
        //  連線的Port號，可以改AppSetting
        private static readonly int port = 8088;
        //  建立.Net Socket


        public  void RunSocket()
        {

            IPEndPoint localEP = new IPEndPoint(IPAddress.Any, port);
            Socket listener = new Socket(localEP.Address.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            try
            {

                listener.Bind(localEP);
                listener.Listen(10);

                Console.WriteLine("等待客戶端連線....");
                Socket sc = listener.Accept();//接受一個連線
                Console.WriteLine("接受到了客戶端：" + sc.RemoteEndPoint.ToString() + "連線....");


                Console.ReadKey();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        //{
        //    TcpListener server = new TcpListener(IPAddress.Parse("127.0.0.1"), 80);

        //    server.Start();
        //    Console.WriteLine("Server has started on 127.0.0.1:80.{0}Waiting for a connection...", Environment.NewLine);

        //    TcpClient client = server.AcceptTcpClient();

        //    Console.WriteLine("A client connected.");
        //}
    }
}
