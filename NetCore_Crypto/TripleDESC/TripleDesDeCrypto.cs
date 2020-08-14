using System;
using System.Security.Cryptography;
using System.Text;

namespace Crypto.TripleDESC
{
    class TripleDesDeCrypto
    {
        //  可以支援到24個字元組
        static string sourceIV = "Q08lG90j";
        public string DesDecrypt(string toDecrypt, string privateKey)
        {
            byte[] enBytes = Convert.FromBase64String(toDecrypt);
            //  初始化
            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider
            {
                Key = TripleLib.GetKeyMd5Hash(privateKey),
                IV = Encoding.UTF8.GetBytes(sourceIV),
                Mode = CipherMode.ECB,
                Padding = PaddingMode.Zeros
            };

            ICryptoTransform cTransform = tdes.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(enBytes, 0, enBytes.Length);
            tdes.Clear();

            return Encoding.UTF8.GetString(resultArray);
        }

    }
}
