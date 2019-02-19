using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
  class Program
  {
    static void Main(string[] args)
    {
      //Random rand = new Random(0);
      //for (int i = 0; i < 10; i++)
      //{
      //  Console.WriteLine(rand.Next(10));
      //}
      int limit = 10;
      List<int> list = new List<int>();
      list.Add(2);
      list.Add(2);

      List<int> original = Enumerable.Range(1, limit).ToList();
      Random rand = new Random();

      //shuffle the list

      List<int> sorted = original.OrderBy(x=>rand.NextDouble()).ToList();
      List<int> sorted2 = original.OrderBy(x => 2).ToList();
      foreach (int i in sorted)
      {
        Console.WriteLine(i);
      }
      Console.ReadKey();
    }
  }
}
