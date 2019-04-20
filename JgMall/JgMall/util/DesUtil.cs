using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace JgMall.util
{
    class DesUtil
    {
        /*
         * 示例秘钥：
         */
        private static string key = "testttssssssssssssssssssssssssss";
        public static string EncryptString(string pToEncrypt)
        {
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] inputByteArray = Encoding.UTF8.GetBytes(pToEncrypt);
            byte[] keyBytes = GetKeyBytes(key);
            des.Mode = CipherMode.ECB;
            des.Padding = PaddingMode.PKCS7;
            des.Key = keyBytes;
            des.IV = keyBytes;
            string result = "";

            using(System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                using(CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write)){
                    cs.Write(inputByteArray, 0, inputByteArray.Length);
                    cs.FlushFinalBlock();
                    cs.Close();
                }
                result = Convert.ToBase64String(ms.ToArray());
                ms.Close();
            }
             return result ;
        }

        public static string DecryptString(string pToDecrypt)
        {

            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] inputByteArray = Convert.FromBase64String(pToDecrypt);

            byte[] keyBytes = GetKeyBytes(key);
            des.Mode = CipherMode.ECB;
            des.Padding = PaddingMode.PKCS7;
            des.Key = keyBytes;
            des.IV = keyBytes;
            string result = "";
            using(MemoryStream ms = new MemoryStream())
            {
                using(CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(inputByteArray, 0, inputByteArray.Length);
                    cs.FlushFinalBlock();
                    cs.Close();
                }
                result = Encoding.UTF8.GetString(ms.ToArray());
                ms.Close();
            }
            return result;
        }

        /// <summary>
        /// 字符串转 keyBytes
        /// </summary>
        /// <param name="keyString"></param>
        /// <returns></returns>
        private static byte[] GetKeyBytes(string keyString)
        {
            byte[] key = new byte[8];
            try
            {
                byte[] str = Convert.FromBase64String(keyString);
                Array.Copy(str, 0, key, 0, 8);
            }
            catch {
            }
            return key;
        }

    }
}
