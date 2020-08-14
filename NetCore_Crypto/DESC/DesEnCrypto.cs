using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleApp1.DESC
{
    class DesEnCrypto
    {

        DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
        /*   
         *   必須為 8 個 ASCII 字元，超過會被自動切除，
         *    舉例今天使用 [ 0123456789 ] 10碼進行加密，
         *    實際上在演算中只會取出 [ 01234567 ]進行加密，
         *    故PHP、JSP使用DES加密時可以直接加密，
         *    但C#較嚴謹，超過8碼會報錯，所以預防安全可以加入SubString。
         */
        public static readonly string DesKey = "1234567A"; //必須為 8 個 ASCII 字元
        public static readonly string DesIv = "A7654321"; //必須為 8 個 ASCII 字元
        /// <summary>
        ///     initial Dse Obj
        /// </summary>
        /// <param name="mode">加密模式</param>
        public DesEnCrypto(CipherMode mode)
        {
            DES.Key = Encoding.UTF8.GetBytes(DesKey);
            DES.IV = Encoding.UTF8.GetBytes(DesIv);
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
