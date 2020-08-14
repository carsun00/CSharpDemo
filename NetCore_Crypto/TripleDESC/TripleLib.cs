using System.Security.Cryptography;
using System.Text;

namespace Crypto.TripleDESC
{
    public class TripleLib
    {

        /// <summary>
        ///     取得Key的MD5
        /// </summary>
        /// <param name="key">原始key值</param>
        /// <returns></returns>
        public static byte[] GetKeyMd5Hash(string key)
        {
            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
            byte[] keyBytes = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            hashmd5.Clear();
            return keyBytes;
        }
    }
}
