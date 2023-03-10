using System;

namespace Loops
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var count = 0;

      //while (count < 10)
      //{
      //  count++;
      //  Console.WriteLine(count);
      //}

      for (int i = 0; i < 5; i++)
      {
        for (int index = 1; index <= 10; index++)
        {
          Console.Write(index);
        }
        Console.WriteLine();
        for (int index = 10; index >= 1; index--)
        {
          Console.Write(index);
        }
        Console.WriteLine();
      }
    }
  }
}
