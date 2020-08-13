using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleApp1.DESC
{
    class DesDeCrypto
    {
        DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
        public static readonly string DesKey = "1234567A"; //必須為 8 個 ASCII 字元
        public static readonly string DesIv = "A7654321"; //必須為 8 個 ASCII 字元
        /// <summary>
        ///      initial Dse Obj
        /// </summary>
        /// <param name="mode">解密模式</param>
        public DesDeCrypto(CipherMode mode)
        {
            DES.Key = Encoding.UTF8.GetBytes(DesKey);
            DES.Key = Encoding.UTF8.GetBytes(DesIv);
            DES.Mode = mode;
        }



        /// <summary>
        ///     解密訊息
        /// </summary>
        /// <param name="CryptoMsg"></param>
        /// <returns></returns>
        public string Encrypto(string CryptoMsg)
        {
            string decrypt = "";

            byte[] RedataByteArray = Convert.FromBase64String(CryptoMsg);
            using(MemoryStream ms = new MemoryStream())
            {
                using(CryptoStream cs = new CryptoStream(ms, DES.CreateDecryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(RedataByteArray, 0, RedataByteArray.Length);
                    cs.FlushFinalBlock();
                    decrypt = Encoding.UTF8.GetString(ms.ToArray());
                }
            }
            return decrypt;
        }
    }
}
