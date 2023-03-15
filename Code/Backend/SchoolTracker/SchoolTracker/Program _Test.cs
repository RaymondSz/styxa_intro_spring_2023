using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace SchoolTracker
{
  internal class Program_Test
  {
    static void Main_Test(string[] args)
    {
      Console.WriteLine("Hany diak van?");
      int n;
      try
      {
        n = int.Parse(Console.ReadLine());
      }
      catch(System.FormatException)
      {
          Console.WriteLine("Hany diak van? Szamot!");
          try
          {
            n = int.Parse(Console.ReadLine());
          }
          catch {

          }
      }
      catch(Exception)
      {
        Console.WriteLine("Something went wrong!");
      }
      finally
      {
        Console.WriteLine("10 diakod lesz!");
        n = 10;
      }

      try
      {
        fuggveny();
        
      }
      catch (Exception)
      {
        Console.WriteLine("nem hal meg");
      }
      

      int[] jegyek = new int[n];
      string[] nevek = new string[n];

      //List<int> jegyek2 = new List<int>();
      //List<string> nevek2 = new List<string>();

      string kovetkezo = "y";

      for (int i = 0; i < n; i++)
      {
        Console.WriteLine("Diak neve: ");
        nevek[i] = Console.ReadLine();

        Console.WriteLine("Diak jegy: ");
        jegyek[i] = int.Parse(Console.ReadLine());
      }

      //while (kovetkezo == "y")
      //{
      //  Console.WriteLine("Diak neve: ");
      //  nevek2.Add(Console.ReadLine());

      //  Console.WriteLine("Diak jegy: ");
      //  jegyek2.Add(int.Parse(Console.ReadLine()));

      //  Console.WriteLine("Lesz uj diak? y/n");
      //  kovetkezo = Console.ReadLine();
      //}

      for (int i = 0; i < n; i++)
      {
        // Console.WriteLine("Nev: " + nevek[i] + ": " + "Jegy: " + jegyek[i]);
        Console.WriteLine($"Nev: {nevek[i]}, Jegy: {jegyek[i]}");
      }


      //for (int i = 0; i < jegyek2.Count; i++)
      //{
      //  // Console.WriteLine("Nev: " + nevek[i] + ": " + "Jegy: " + jegyek[i]);
      //  Console.WriteLine($"Nev: {nevek2[i]}, Jegy: {jegyek2[i]}");
      //}

      //foreach (var item in nevek2)
      //{
      //  Console.WriteLine(item);
      //}
    }
    public static void fuggveny()
    {
      throw new Exception("meghal!");
    }
  }
}
