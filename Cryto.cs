using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace BeeUi.Commons
{
    public class Crypto
    {
        private string coEncryptionKey;

        public Crypto()
        {
            coEncryptionKey = "INVX";
        }

        public string EncryptString128Bit(string strTextToBeEncrypted, string strEncryptionKey)
        {
            byte[] inArray = new byte[0];
            byte[] rgbIV = new byte[16]
            {
            121, 241, 10, 1, 132, 74, 11, 39, 255, 91,
            45, 78, 14, 211, 22, 62
            };
            MemoryStream memoryStream = new MemoryStream();
            strTextToBeEncrypted = StripNullCharacters(strTextToBeEncrypted);
            byte[] bytes = Encoding.ASCII.GetBytes(strTextToBeEncrypted.ToCharArray());
            int num = Strings.Len(coEncryptionKey);
            if (num >= 32)
            {
                coEncryptionKey = Strings.Left(coEncryptionKey, 32);
            }
            else
            {
                num = Strings.Len(coEncryptionKey);
                int number = checked(32 - num);
                coEncryptionKey += Strings.StrDup(number, "X");
            }

            byte[] bytes2 = Encoding.ASCII.GetBytes(coEncryptionKey.ToCharArray());
            RijndaelManaged rijndaelManaged = new RijndaelManaged();
            try
            {
                CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(bytes2, rgbIV), CryptoStreamMode.Write);
                cryptoStream.Write(bytes, 0, bytes.Length);
                cryptoStream.FlushFinalBlock();
                inArray = memoryStream.ToArray();
                memoryStream.Close();
                cryptoStream.Close();
            }
            catch (Exception projectError)
            {
                ProjectData.SetProjectError(projectError);
                ProjectData.ClearProjectError();
            }

            return Convert.ToBase64String(inArray);
        }

        public string DecryptString128Bit(string vstrStringToBeDecrypted, string vstrDecryptionKey)
        {
            byte[] rgbIV = new byte[16]
            {
            121, 241, 10, 1, 132, 74, 11, 39, 255, 91,
            45, 78, 14, 211, 22, 62
            };
            RijndaelManaged rijndaelManaged = new RijndaelManaged();
            string empty = string.Empty;
            byte[] array = Convert.FromBase64String(vstrStringToBeDecrypted);
            int num = Strings.Len(coEncryptionKey);
            checked
            {
                if (num >= 32)
                {
                    coEncryptionKey = Strings.Left(coEncryptionKey, 32);
                }
                else
                {
                    num = Strings.Len(coEncryptionKey);
                    int number = 32 - num;
                    coEncryptionKey += Strings.StrDup(number, "X");
                }

                byte[] bytes = Encoding.ASCII.GetBytes(coEncryptionKey.ToCharArray());
                byte[] array2 = new byte[array.Length + 1];
                MemoryStream memoryStream = new MemoryStream(array);
                try
                {
                    CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(bytes, rgbIV), CryptoStreamMode.Read);
                    cryptoStream.Read(array2, 0, array2.Length);
                    cryptoStream.FlushFinalBlock();
                    memoryStream.Close();
                    cryptoStream.Close();
                }
                catch (Exception projectError)
                {
                    ProjectData.SetProjectError(projectError);
                    ProjectData.ClearProjectError();
                }

                return StripNullCharacters(Encoding.ASCII.GetString(array2));
            }
        }

        public string StripNullCharacters(string vstrStringWithNulls)
        {
            int num = 1;
            string text = vstrStringWithNulls;
            while (num > 0)
            {
                num = Strings.InStr(num, vstrStringWithNulls, "\0");
                if (num > 0)
                {
                    text = checked(Strings.Left(text, num - 1) + Strings.Right(text, Strings.Len(text) - num));
                }

                if (num > text.Length)
                {
                    break;
                }
            }

            return text;
        }
    }
}
