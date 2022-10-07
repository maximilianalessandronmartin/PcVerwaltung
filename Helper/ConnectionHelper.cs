using System;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;

namespace PcVerwaltung.Helper;

public static class ConnectionHelper
{
   public static string ConnString(string name)
   {
      return ConfigurationManager.ConnectionStrings[name].ConnectionString;
   }
   
   
   public static string GetSHA384(string userName, string password)
   {
      // SHA classes are disposable, use using to ensure any managed resources are properly disposed of by the runtime
      using (var sha = SHA384.Create())
      {

         // convert the username and password into bytes
         byte[] preHash = Encoding.ASCII.GetBytes(userName + password);

         // hash the bytes
         byte[] hash = sha.ComputeHash(preHash);

         // convert the raw bytes into a string that we can save to a database
         return Convert.ToBase64String(hash);
      }
   }


   public static bool MatchSha1(byte[] p1, byte[] p2)
   {
      bool result = false;
      if (p1 != null && p2 != null)
      {
         if (p1.Length == p2.Length)
         {
            result = true;
            for (int i = 0; i < p1.Length; i++)
            {
               if (p1[i] != p2[i])
               {
                  result = false;
                  break;
               }
            }
         }
      }

      return result;
   }
}