using Interface_Oriented.ModelAuthentication.Entity_GenericSup;
using Interface_Oriented.ModelAuthentication.Interface;
using System;

namespace Interface_Oriented.ModelAuthentication.Entity_Generic
{
    public class LobbyServerInfo : ILobby<ServerInfoData>
    {
        public string Status { get; set; }
        public string Message { get; set; }
        public string ErrorCode { get; set; }
        public ServerInfoData DataInfo { get; set; }

        public bool CheckStatus()
        {
            throw new NotImplementedException();
        }
    }
}
