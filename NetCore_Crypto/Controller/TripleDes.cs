using Crypto.Interface;
using Crypto.TripleDESC;
using System;

namespace Crypto.Controller
{
    class TripleDes : ICrypto
    {
        public static readonly string DesKey = "1234567AAAAAA";
        public void Display(string msg)
        {
            Console.WriteLine("加解密的訊息：" + msg);

            //  加密
            string OriginalMsg = string.Empty;
            TripleDesEnCrypto desEn = new TripleDesEnCrypto();
            OriginalMsg = desEn.DesEncrypt(msg, DesKey);
            Console.WriteLine(OriginalMsg);

            //  解密
            string decrypt = string.Empty;
            TripleDesDeCrypto desDe = new TripleDesDeCrypto();
            decrypt = desDe.DesDecrypt(OriginalMsg, DesKey);
            Console.WriteLine(decrypt);
        }
    }
}
