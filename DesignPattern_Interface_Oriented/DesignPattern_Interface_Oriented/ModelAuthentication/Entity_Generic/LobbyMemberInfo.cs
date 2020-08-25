using Interface_Oriented.ModelAuthentication.Entity_GenericSup;
using Interface_Oriented.ModelAuthentication.Interface;
using System;

namespace Interface_Oriented.ModelAuthentication.Entity_Generic
{
    public class LobbyMemberInfo : ILobby<MemberInfo>
    {
        public string Status { get ; set ; }
        public string Message { get ; set ; }
        public string ErrorCode { get ; set ; }
        public MemberInfo DataInfo { get ; set; }

        public bool CheckStatus()
        {
            //  實作檢驗機制。
            throw new NotImplementedException();
        }
    }
}
