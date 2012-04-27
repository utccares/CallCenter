using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Logging
{

   public static void LogTrace(string message)
   {
      Console.WriteLine(message);
   }

   public static void LogDebug(string message)
   {
      Console.WriteLine(message);
   }

   public static void LogInfo(string message)
   {
      Console.WriteLine(message);
   }

   public static void LogWarning(string message)
   {
      Console.WriteLine(message);
   }

   public static void LogError(string message)
   {
      Console.WriteLine(message);
   }

   public static void LogError(Exception ex)
   {
      Console.WriteLine(ex.Message);
   }

   public static void LogError(string message, Exception ex)
   {
      Console.WriteLine(message);
   }

}