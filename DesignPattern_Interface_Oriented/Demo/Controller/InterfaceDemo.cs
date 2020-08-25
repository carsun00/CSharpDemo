

using Demo.Controller.Initial;
using Interface_Oriented.ModelAuthentication.Entity_Generic;
using System;

namespace Demo.Controller
{
    /// <summary>
    ///     實做三種透過介面產生的Class
    /// </summary>
    public class InterfaceDemo
    {
        public void Display()
        {
            #region LobbyMemberInfo轉換
            IniMember iniMember = new IniMember();
            LobbyMemberInfo member = iniMember.IniLobbyMemberInfo();
            iniMember.OutLobbyMemberInfo(member);
            Console.WriteLine("");
            #endregion


            #region LobbyBulletin轉換
            IniBulletin IniBulletin = new IniBulletin();
            LobbyBulletin Bulletin = IniBulletin.IniLobbyBulletin();
            IniBulletin.OutLobbyBulletin(Bulletin);
            Console.WriteLine("");
            #endregion


            #region LobbyServerInfo轉換
            IniServerInfo IniServerInfo = new IniServerInfo();
            LobbyServerInfo ServerInfo = IniServerInfo.IniLobbyServerInfo();
            IniServerInfo.OutLobbyServerInfo(ServerInfo);
            Console.WriteLine("");
            #endregion
        }

    }
}
