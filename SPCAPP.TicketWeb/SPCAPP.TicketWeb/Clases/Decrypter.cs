using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SPCAPP.TicketWeb.Clases
{
    public class Decrypter
    {
        private static string key = "";

        public static string Encriptar(string texto)
        {
            if (texto == "")
                return "";
            byte[] bytes = Encoding.UTF8.GetBytes(texto);
            MD5CryptoServiceProvider cryptoServiceProvider1 = new MD5CryptoServiceProvider();
            byte[] hash = cryptoServiceProvider1.ComputeHash(Encoding.UTF8.GetBytes(Decrypter.key));
            cryptoServiceProvider1.Clear();
            TripleDESCryptoServiceProvider cryptoServiceProvider2 = new TripleDESCryptoServiceProvider();
            cryptoServiceProvider2.Key = hash;
            cryptoServiceProvider2.Mode = CipherMode.ECB;
            cryptoServiceProvider2.Padding = PaddingMode.PKCS7;
            byte[] inArray = cryptoServiceProvider2.CreateEncryptor().TransformFinalBlock(bytes, 0, bytes.Length);
            cryptoServiceProvider2.Clear();
            return Convert.ToBase64String(inArray, 0, inArray.Length);
        }

        public static string Desencriptar(string textoEncriptado)
        {
            if (textoEncriptado == "")
                return "";
            byte[] inputBuffer = Convert.FromBase64String(textoEncriptado);
            MD5CryptoServiceProvider cryptoServiceProvider1 = new MD5CryptoServiceProvider();
            byte[] hash = cryptoServiceProvider1.ComputeHash(Encoding.UTF8.GetBytes(Decrypter.key));
            cryptoServiceProvider1.Clear();
            TripleDESCryptoServiceProvider cryptoServiceProvider2 = new TripleDESCryptoServiceProvider();
            cryptoServiceProvider2.Key = hash;
            cryptoServiceProvider2.Mode = CipherMode.ECB;
            cryptoServiceProvider2.Padding = PaddingMode.PKCS7;
            byte[] bytes = cryptoServiceProvider2.CreateDecryptor().TransformFinalBlock(inputBuffer, 0, inputBuffer.Length);
            cryptoServiceProvider2.Clear();
            return Encoding.UTF8.GetString(bytes);
        }
    }
}
