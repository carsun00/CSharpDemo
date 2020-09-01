using System;
using System.Security.Cryptography;
using System.Text;

namespace Crypto.AES
{
    class AesEnCrypto
    {
        static readonly string sourceIV = "77Koclqal3zd233L";
        static readonly string AseKey = "MiyuIllyasveilVonEinzbernY11e99R";

        public string AesEncrypt(string toEncrypt)
        {
            AesCryptoServiceProvider aes = new AesCryptoServiceProvider
            {
                Key = Encoding.UTF8.GetBytes(AseKey),
                Mode = CipherMode.CBC,
                Padding = PaddingMode.PKCS7,
                IV = Encoding.UTF8.GetBytes(sourceIV),
            };

            byte[] toEncryptArray = Encoding.UTF8.GetBytes(toEncrypt);
            byte[] resultArray = aes.CreateEncryptor().TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return Convert.ToBase64String(resultArray, 0, resultArray.Length);

        }



        /// <summary>
        ///     同事版
        /// </summary>
        /// <param name="plainText"></param>
        /// <returns></returns>
        public (bool, string) Encrypt(string plainText)
        {
            Aes aes = null;

            try
            {
                aes = Aes.Create();

                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;
                aes.Key = Encoding.UTF8.GetBytes(AseKey);
                aes.IV = Encoding.UTF8.GetBytes(sourceIV);

                byte[] plainByteArray = Encoding.UTF8.GetBytes(plainText);
                byte[] cipherByteArray = aes.CreateEncryptor().TransformFinalBlock(plainByteArray, 0, plainByteArray.Length);

                string cipherText = Convert.ToBase64String(cipherByteArray);

                return (true, cipherText);
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
