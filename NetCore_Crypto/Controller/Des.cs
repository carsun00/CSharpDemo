using ConsoleApp1.DESC;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Crypto.Controller
{
    class Des
    {
        public void Display(string msg)
        {
            Console.WriteLine("加解密的訊息：" + msg);

            //  加密
            string OriginalMsg = string.Empty;
            DesEnCrypto desEn = new DesEnCrypto(CipherMode.ECB);
            OriginalMsg = desEn.Encrypto(msg);
            Console.WriteLine(OriginalMsg);

            //  解密
            string decrypt = string.Empty;
            DesDeCrypto desDe = new DesDeCrypto(CipherMode.ECB);
            decrypt = desDe.Encrypto(OriginalMsg);
            Console.WriteLine(decrypt);
        }
    }
}
