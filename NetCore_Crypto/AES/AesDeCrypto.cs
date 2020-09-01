using System;
using System.Security.Cryptography;
using System.Text;

namespace Crypto.AES
{
    class AesDeCrypto
    {
        static string sourceIV = "77Koclqal3zd233L";
        static string AseKey = "MiyuIllyasveilVonEinzbernY11e99R";

        public string AesDecrypt(string toDecrypt)
        {
            byte[] enBytes = Convert.FromBase64String(toDecrypt);
            //  初始化
            AesCryptoServiceProvider tdes = new AesCryptoServiceProvider
            {
                Key = Encoding.UTF8.GetBytes(AseKey),
                IV = Encoding.UTF8.GetBytes(sourceIV),
                Mode = CipherMode.CBC,
                Padding = PaddingMode.Zeros
            };

            ICryptoTransform cTransform = tdes.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(enBytes, 0, enBytes.Length);
            tdes.Clear();

            return Encoding.UTF8.GetString(resultArray);
        }

        /// <summary>
        ///		同事版
        /// </summary>
        /// <param name="plainText"></param>
        /// <returns></returns>
        public (bool, string) Decryptor(string plainText)
        {
            string result = string.Empty;

            Aes aes = null;
            try
            {
                aes = Aes.Create();
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;
                aes.Key = Encoding.UTF8.GetBytes(AseKey);
                aes.IV = Encoding.UTF8.GetBytes(sourceIV);
                byte[] cipherByteArray = Convert.FromBase64String(plainText);
                byte[] plainByteArray = aes.CreateDecryptor().TransformFinalBlock(cipherByteArray, 0, cipherByteArray.Length);
                result = Encoding.UTF8.GetString(plainByteArray);

                return (true, result);
            }
            catch
            {
                return (false, null);
            }
            finally
            {
                if(aes != null)
                {
                    aes.Dispose();
                }
            }
        }
    }
}
