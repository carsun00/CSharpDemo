using Interface_Oriented.ModelAuthentication.Entity_Generic;
using Newtonsoft.Json;

namespace Demo.Controller.Initial
{
    public class IniBulletin
    {
        readonly string BulletinJson = "{\"Status\":\"1\",\"Message\":\"Sucess\",\"ErrorCode\":\"\",\"DataInfo\":\"Just String Message\"}";

        public IniMember NewMember()
        {
            return new IniMember();
        }

        public LobbyBulletin IniLobbyBulletin()
        {
            Lib.CondoleString(BulletinJson, "字串轉物件");
            return JsonConvert.DeserializeObject<LobbyBulletin>(BulletinJson);
        }

        public string OutLobbyBulletin(LobbyBulletin Obj)
        {
            string returnString = string.Empty;
            Lib.CondoleObj(Obj.ToString());
            returnString = JsonConvert.SerializeObject(Obj);
            Lib.CondoleString(returnString, "物件轉字串");
            return returnString;
        }
    }
}
