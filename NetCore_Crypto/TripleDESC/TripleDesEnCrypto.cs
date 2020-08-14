using System;
using System.Security.Cryptography;
using System.Text;

namespace Crypto.TripleDESC
{
    class TripleDesEnCrypto
    {
        //  可以支援到24個字元組
        static string sourceIV = "Q08lG90j";
        public string DesEncrypt(string toEncrypt, string privateKey)
        {
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);

            //  初始化
            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider
            {
                Key = TripleLib.GetKeyMd5Hash(privateKey),
                IV = Encoding.UTF8.GetBytes(sourceIV),
                Mode = CipherMode.ECB,
                Padding = PaddingMode.Zeros
            };

            ICryptoTransform cTransform = tdes.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            tdes.Clear();

            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

    }
}
