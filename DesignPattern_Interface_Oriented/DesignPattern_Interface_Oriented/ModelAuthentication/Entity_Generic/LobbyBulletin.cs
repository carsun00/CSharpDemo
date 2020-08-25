using Interface_Oriented.ModelAuthentication.Interface;
using System;

namespace Interface_Oriented.ModelAuthentication.Entity_Generic
{
    public class LobbyBulletin : ILobby<string>
    {
        public string Status { get; set; }
        public string Message { get; set; }
        public string ErrorCode { get; set; }
        public string DataInfo { get; set; }

        public bool CheckStatus()
        {
            throw new NotImplementedException();
        }
    }
}
