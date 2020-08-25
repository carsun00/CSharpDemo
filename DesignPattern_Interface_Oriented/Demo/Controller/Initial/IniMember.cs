using Interface_Oriented.ModelAuthentication.Entity_Generic;
using Newtonsoft.Json;

namespace Demo.Controller.Initial
{
    public class IniMember
    {
        readonly string MemberJson = "{\"Status\":\"1\",\"Message\":\"Sucess\",\"ErrorCode\":\"\",\"DataInfo\":{\"Company\":\"Demo\",\"MemberAccount\":\"User0001\",\"MemberName\":\"TestUser\",\"OpenServerId\":\"90001\",\"SystemCode\":\"Member\",\"WebId\":\"TestWeb\"}}";

        public IniMember NewMember()
        {
            return new IniMember();
        }

        public LobbyMemberInfo IniLobbyMemberInfo()
        {
            Lib.CondoleString(MemberJson, "字串轉物件");
            return JsonConvert.DeserializeObject<LobbyMemberInfo>(MemberJson);
        }

        public string OutLobbyMemberInfo(LobbyMemberInfo Obj)
        {
            string returnString = string.Empty;
            Lib.CondoleObj(Obj.ToString());
            returnString = JsonConvert.SerializeObject(Obj);
            Lib.CondoleString(returnString, "物件轉字串");
            return returnString;
        }
    }
}
