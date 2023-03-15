using System;
using System.Collections.Generic;

namespace SchoolTracker
{
  internal class Program
  {
    static void Main(string[] args)
    {
      List<Student> diakok = new List<Student>();

      Student diak1 = new Student();
      Student diak2 = new Student();

      Console.WriteLine(diak1.GetHashCode());
      Console.WriteLine(diak2.GetHashCode());

      //diak1.Name = "Pista";

      //diak2.Name = diak1.Name;

      //diak1.Name = "LAci";

      string kovetkezo = "y";

      while (kovetkezo == "y")
      {
        Student diak = new Student();

        Console.WriteLine("Diak neve: ");
        diak.Name = Console.ReadLine();

        Console.WriteLine("Diak jegy: ");
        diak.Grade = int.Parse(Console.ReadLine());

        diakok.Add(diak);

        Console.WriteLine("Lesz uj diak? y/n");
        kovetkezo = Console.ReadLine();
      }

      foreach (var item in diakok)
      {
        Console.WriteLine($"Nev: {item.Name}, Jegy: {item.Grade}");
      }
    }
  }
}
