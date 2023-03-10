using System;

namespace Arrays
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var tomb = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

      for(int i = 0; i < tomb.Length; i++)
      {
        Console.WriteLine(tomb[i]);
      }
    }
  }
}
