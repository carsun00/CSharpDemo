namespace WebSocket
{

    /// <summary>
    /// http://websocket.org/echo.html
    /// http://limitedcode.blogspot.com/2014/05/websocket-websocket-server-console.html
    /// 
    /// </summary>
    class Program
    {

        //  Socket class    https://docs.microsoft.com/zh-tw/dotnet/api/system.net.sockets.socket?view=netcore-3.1
        //  AddressFamily   https://docs.microsoft.com/zh-tw/dotnet/api/system.net.sockets.addressfamily?view=netcore-3.1
        //  SocketType      https://docs.microsoft.com/zh-tw/dotnet/api/system.net.sockets.sockettype?view=netcore-3.1
        //  ProtocolType    https://docs.microsoft.com/zh-tw/dotnet/api/system.net.sockets.protocoltype?view=netcore-3.1

        static void Main(string[] args)
        {
            Server s = new Server();
            s.RunSocket();

        }
    }
}