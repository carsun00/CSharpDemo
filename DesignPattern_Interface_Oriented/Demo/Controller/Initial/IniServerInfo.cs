using Interface_Oriented.ModelAuthentication.Entity_Generic;
using Newtonsoft.Json;

namespace Demo.Controller.Initial
{
    class IniServerInfo
    {
        readonly string ServerJson = "{\"Status\":\"1\",\"Message\":\"Sucess\",\"ErrorCode\":\"\",\"DataInfo\":{\"Row\":\"2\",\"Data\":[{\"ServerId\":\"A0001\",\"ServerNo\":\"90001\",\"GameName\":\"Game01\",\"LobbyName\":\"Lobby1\",\"DeskNo\":\"A\",\"LobbyTag\":\"open\"},{\"ServerId\":\"A0002\",\"ServerNo\":\"90002\",\"GameName\":\"Game02\",\"LobbyName\":\"Lobby2\",\"DeskNo\":\"B\",\"LobbyTag\":\"Close\"}]}}";

        public IniMember NewMember()
        {
            return new IniMember();
        }

        public LobbyServerInfo IniLobbyServerInfo()
        {
            Lib.CondoleString(ServerJson, "字串轉物件");
            return JsonConvert.DeserializeObject<LobbyServerInfo>(ServerJson);
        }

        public string OutLobbyServerInfo(LobbyServerInfo Obj)
        {
            string returnString = string.Empty;
            Lib.CondoleObj(Obj.ToString());
            returnString = JsonConvert.SerializeObject(Obj);
            Lib.CondoleString(returnString, "物件轉字串");
            return returnString;
        }
    }
}
