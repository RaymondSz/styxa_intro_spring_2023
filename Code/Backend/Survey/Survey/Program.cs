using System;
using System.Transactions;
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
      var month = int.Parse(ReadFromConsole("In which month you were born?"));


      //Console.WriteLine(month);
      //if (month == "march")
      //{
      //  Console.WriteLine("Halak");
      //}
      //if (month == "february")
      //{
      //  Console.WriteLine("Vizonto");
      //}


      switch (month)
      {
        case 1:
          Console.WriteLine("januar");
          break;
        case 2:
          Console.WriteLine("vizomt");
          break;
      }
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
