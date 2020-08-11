using SuperWebSocket;
using System;

namespace WebSocket_UsePackage_ASP.Net
{
    /// <summary>
    ///     使用Nuget套件實現WS連線。
    ///     闡述使用方法。
	///		WS測式 		http://websocket.org/echo.html
    ///     參考影片 :　https://www.youtube.com/watch?v=JbXurSfeceY
    /// </summary>
    class Program
    {
        private static WebSocketServer wsServer;
        static void Main(string[] args)
        {
            wsServer = new WebSocketServer();
            //  指定Port號
            int port = 8088;
            //  啟動Server
            wsServer.Setup(port);
            //  增加建立連線的功能
            wsServer.NewSessionConnected += WsServer_NewSessionConnected;
            //  增加回覆訊息的判斷 通常回覆邏輯會在這邊執行
            wsServer.NewMessageReceived += WsServer_NewMessageReceived;
            //  未知使用
            wsServer.NewDataReceived += WsServer_NewDataReceived;
            //  關閉連線。
            wsServer.SessionClosed += WsServer_SessionClosed;
            wsServer.Start();
            Console.WriteLine("伺服器執行Port : " + port + " . 請按ENTER離開...");
            Console.ReadKey();

            wsServer.Stop();

        }

        private static void WsServer_SessionClosed(WebSocketSession session, SuperSocket.SocketBase.CloseReason value)
        {
            Console.WriteLine("連線關閉");
        }

        private static void WsServer_NewDataReceived(WebSocketSession session, byte[] value)
        {
            Console.WriteLine("NewDataReceived");
        }

        private static void WsServer_NewMessageReceived(WebSocketSession session, string value)
        {
            Console.WriteLine("Client端回覆 : " + value);
            if (value == "Hello Server")
            {
                session.Send("Hello client");

            }
            else
            {
                session.Send("Hello World");
            }

        }

        private static void WsServer_NewSessionConnected(WebSocketSession session)
        {
            Console.WriteLine("連線建立");
        }
    }
}
