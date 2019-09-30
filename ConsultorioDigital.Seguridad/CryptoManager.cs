using System;
using System.Security.Cryptography;
using System.Text;

namespace ConsultorioDigital.Seguridad
{
  /* https://docs.microsoft.com/en-us/dotnet/api/system.security.cryptography.md5?view=netframework-4.8 */
  public class CryptoManager
  {
    public static string Cifrar(string input)
    {
      MD5 md5Hash = MD5.Create();

      // Convert the input string to a byte array and compute the hash.
      byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

      // Create a new Stringbuilder to collect the bytes
      // and create a string.
      StringBuilder sBuilder = new StringBuilder();

      // Loop through each byte of the hashed data 
      // and format each one as a hexadecimal string.
      for (int i = 0; i < data.Length; i++)
      {
        sBuilder.Append(data[i].ToString("x2"));
      }

      // Return the hexadecimal string.
      return sBuilder.ToString();
    }

    public static bool Comparar(string input, string hash)
    {
      // Hash the input.
      string hashOfInput = Cifrar(input);

      // Create a StringComparer an compare the hashes.
      StringComparer comparer = StringComparer.OrdinalIgnoreCase;

      return 0 == comparer.Compare(hashOfInput, hash);
    }
  }
}
