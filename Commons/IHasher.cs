using System.Text;

namespace iS.Common.Cryptography
{
    /// <summary>
    /// Interface für alle Klassen die aus einem String einen Hash erzeugen
    /// </summary>
    /// <ChangeLog>
    /// <Create Datum="09.11.2012" Entwickler="MEckert" />
    /// </ChangeLog>
    public interface IHasher
    {
        /// <summary>
        /// Encoding das zum string gehört
        /// </summary>
        /// <ChangeLog>
        /// <Create Datum="09.11.2012" Entwickler="MEckert" />
        /// </ChangeLog>
        Encoding Encoding { get; set; }

        /// <summary>
        /// Erzeugt aus einem Bytearray den Hash
        /// </summary>
        /// <param name="inputBytes">Unverhashte Bytes</param>
        /// <returns>Verhashte Bytes</returns>
        /// <ChangeLog>
        /// <Create Datum="09.11.2012" Entwickler="MEckert" />
        /// </ChangeLog>
        byte[] CalculateHash(byte[] inputBytes);

        /// <summary>
        /// Erzeugt aus einem String den Hash
        /// </summary>
        /// <param name="inputString">Unverhashter String</param>
        /// <returns>Verhashter String</returns>
        /// <ChangeLog>
        /// <Create Datum="09.11.2012" Entwickler="MEckert" />
        /// </ChangeLog>
        string CalculateHash(string inputString);
    }
}
