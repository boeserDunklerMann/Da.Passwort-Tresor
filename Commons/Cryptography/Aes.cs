using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.IO;

namespace DA.lib.Commons.Cryptography
{
    /// <summary>
    /// Ver- oder Entschlüsselt mit AES
    /// </summary>
    [ClassInterface(ClassInterfaceType.AutoDual)]
    public class Aes 
	{
        private const string DEFAULT_IV = "Default-InitVekt";

        /// <summary>
        /// Schlüssel mit dem ver- / entschlüsselt werden soll
        /// </summary>
        [ComVisible(true)]
        public byte[] Key { get; set; }

        /// <summary>
        /// Initialisierungsvektor
        /// </summary>
        [ComVisible(true)]
        public byte[] IV { get; set; }

        /// <summary>
        /// Konstruktor
        /// </summary>
        public Aes()
        {
            IV = Encoding.UTF8.GetBytes(DEFAULT_IV);
        }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="key">Schlüssel mit dem ver- / entschlüsselt werden soll</param>
        public Aes(byte[] key)
            : this()
        {
            Key = key;
        }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="key">Schlüssel mit dem ver- / entschlüsselt werden soll</param>
        /// <param name="iV">Initialisierungsvektor</param>
        public Aes(byte[] key, byte[] iV)
            : this(key)
        {
            IV = iV;
        }

        /// <summary>
        /// Verschlüsselt einen String
        /// </summary>
        /// <param name="plainText">String der verschlüsselt werden soll</param>
        /// <returns>Verschlüsselter String als Byte-Array</returns>
        [ComVisible(true)]
        public byte[] Encode(string plainText)
        {
            byte[] cipherText;
            using (AesManaged aesManaged = new AesManaged { KeySize = Key.Length*8, Key = Key, IV = IV})
            {
                ICryptoTransform encoder = aesManaged.CreateEncryptor();
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream,encoder,CryptoStreamMode.Write))
                    {
                        using (StreamWriter writer = new StreamWriter(cryptoStream))
                        {
                            writer.Write(plainText);
                        }
                        cipherText = memoryStream.ToArray();
                    }
                }
            }
            return cipherText;
        }

        /// <summary>
        /// Entschlüsselt ein Byte-Array
        /// </summary>
        /// <param name="cipherText">Byte-Array das Entschlüsselt werden soll</param>
        /// <returns>Entschlüsselter String</returns>
        [ComVisible(true)]
        public string Decode(byte[] cipherText)
        {
            string plainText;
            using (AesManaged aesManaged = new AesManaged { KeySize = Key.Length*8, Key = Key, IV = IV })
            {
                ICryptoTransform decoder = aesManaged.CreateDecryptor();
                using (MemoryStream memoryStream = new MemoryStream(cipherText))
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, decoder, CryptoStreamMode.Read))
                    {
                        using (StreamReader reader = new StreamReader(cryptoStream))
                        {
                            plainText = reader.ReadToEnd();
                        }
                    }
                }
            }
            return plainText;
        }
    }
}
