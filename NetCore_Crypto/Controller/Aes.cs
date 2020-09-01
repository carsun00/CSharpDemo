using Crypto.AES;
using Crypto.Interface;
using System;

namespace Crypto.Controller
{
    class Aes : ICrypto
    {
        public void Display(string msg)
        {

            Console.WriteLine("加解密的訊息(My Version)：" + msg);

            //  加密
            string OriginalMsg = string.Empty;
            AesEnCrypto AesEn = new AesEnCrypto();
            OriginalMsg = AesEn.AesEncrypt(msg);
            Console.WriteLine(OriginalMsg);
            //  解密
            string decrypt = string.Empty;
            AesDeCrypto AesDe = new AesDeCrypto();
            decrypt = AesDe.AesDecrypt(OriginalMsg);
            Console.WriteLine(decrypt);

            Console.WriteLine("加解密的訊息(同事版)：" + msg);
            //  加密
            var AesEn2 = AesEn.Encrypt(msg);
            Console.WriteLine(AesEn2);
            //  解密
            var AesDe2 = AesDe.Decryptor(AesEn2.Item2);
            Console.WriteLine(AesDe2);

        }
    }
}
