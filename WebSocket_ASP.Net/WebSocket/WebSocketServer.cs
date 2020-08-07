using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Security.Cryptography;

namespace WebSocket
{
    class WebSocketServer
    {
        // SHA1加密
        private SHA1 _sha1 = SHA1CryptoServiceProvider.Create();
        // WebSocket專用GUID                          
        private static readonly String GUID = "258EAFA5-E914-47DA-95CA-C5AB0DC85B11";
        // 儲存所有Client連線的佇列             
        //private List<WebSocketConnection> _connections = new List<WebSocketConnection>();
        //// 建立連線後觸發的事件                       
        //public event ClientConnectedHandler OnConnected;
        // 通訊埠
        public Int32 Port { get; private set; }
    }
}
