using System.Security.Cryptography;
using System.Text;

namespace Crypto.MD5crypto
{
    class Md5EnCrypto
    {
        public string Encrypto(string msg)
        {
            MD5 md5 = MD5.Create();
            // 轉換成位元組
            byte[] ByteData = Encoding.UTF8.GetBytes(msg);
            // 加密
            byte[] EnCrypto = md5.ComputeHash(ByteData);
            // 轉回字串
            StringBuilder sb = new StringBuilder();
            foreach(byte b in EnCrypto)
            {
                //  返回16進位
                sb.Append(b.ToString("x2"));
            }
            return sb.ToString();
        }
    }
}
