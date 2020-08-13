using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleApp1.DESC
{
    class DesEnCrypto
    {

        DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
        public static readonly string DesKey = "1234567A"; //必須為 8 個 ASCII 字元
        public static readonly string DesIv = "A7654321"; //必須為 8 個 ASCII 字元
        /// <summary>
        ///     initial Dse Obj
        /// </summary>
        /// <param name="mode">加密模式</param>
        public DesEnCrypto(CipherMode mode)
        {
            DES.Key = Encoding.UTF8.GetBytes(DesKey);
            DES.Key = Encoding.UTF8.GetBytes(DesIv);
            DES.Mode = mode;
        }

        /// <summary>
        ///     加密訊息
        /// </summary>
        /// <param name="OriginalMsg"></param>
        /// <returns></returns>
        public string Encrypto(string OriginalMsg)
        {
            string encrypt = "";
            byte[] dataByteArray = Encoding.UTF8.GetBytes(OriginalMsg);
            using(MemoryStream ms = new MemoryStream())
            {
                using(CryptoStream cs = new CryptoStream(ms, DES.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(dataByteArray, 0, dataByteArray.Length);
                    cs.FlushFinalBlock();
                    encrypt = Convert.ToBase64String(ms.ToArray());
                }
            }
            return encrypt;
        }
    }
}
