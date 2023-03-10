using System;

namespace Passcode
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var originalPasscode = "password1!";
      Console.WriteLine("What is the password?");
 
      var passcode = Console.ReadLine();

      if (passcode.ToLower() == originalPasscode.ToLower())
      {
        Console.WriteLine("Authorized");
      }
      else
      {
        Console.WriteLine("Not Authorized");
      }
    }
  }
}
