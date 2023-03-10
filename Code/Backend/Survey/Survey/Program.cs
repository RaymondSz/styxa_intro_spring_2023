using System;
using System.Xml.Linq;

namespace Survey
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var name = ReadFromConsole("What's your name:");
      var cnp = ReadFromConsole("What's your CNP:");
      var age = ReadFromConsole("What's your age:");
      var gender = ReadFromConsole("What's your gender:");
    }

    static string ReadFromConsole(string question)
    {
      var text = "";
      while (text == "") {
        Console.WriteLine(question);
        text = Console.ReadLine();
      }
      SayThankYou();
      if (text == "Robi")
      {
        return "Styxa";
      }

      return text;
    }

    static void SayThankYou()
    {
      Console.WriteLine("Thank You!");
    }
  }
}
