using System;
using System.Security.Cryptography;
using System.Text;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;


namespace JgMall.util
{
    class RsaUtil
    {
        /*
         * RSA秘钥：
         */

        private static string PublicKey = "sssssssssssssstesttttttttttttttttttttttttttttttttttttttttttttt";
        private static string CodingType = "UTF-8";

        public static string EncryptCSharp( string data)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            byte[] cipherbytes;
            rsa.FromXmlString(RSAPublicKeyJava2DotNet());
            //☆☆☆☆.NET 4.6以后特有☆☆☆☆
            //HashAlgorithmName hashName = new System.Security.Cryptography.HashAlgorithmName(hashAlgorithm);
            //RSAEncryptionPadding padding = RSAEncryptionPadding.OaepSHA512;//RSAEncryptionPadding.CreateOaep(hashName);//.NET 4.6以后特有               
            //cipherbytes = rsa.Encrypt(Encoding.GetEncoding(encoding).GetBytes(data), padding);
            //☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆

            //☆☆☆☆.NET 4.6以前请用此段代码☆☆☆☆
            cipherbytes = rsa.Encrypt(Encoding.GetEncoding(CodingType).GetBytes(data), false);

            return Convert.ToBase64String(cipherbytes);
        }


        public static string RSAPublicKeyJava2DotNet()
        {
            RsaKeyParameters publicKeyParam = (RsaKeyParameters)PublicKeyFactory.CreateKey(Convert.FromBase64String(PublicKey));
            return string.Format("<RSAKeyValue><Modulus>{0}</Modulus><Exponent>{1}</Exponent></RSAKeyValue>",
                Convert.ToBase64String(publicKeyParam.Modulus.ToByteArrayUnsigned()),Convert.ToBase64String(publicKeyParam.Exponent.ToByteArrayUnsigned()));
        }
    }
}
