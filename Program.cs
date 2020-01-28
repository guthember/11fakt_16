using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osszadas
{
  class Program
  {
    // két egész paramétere van
    static int Osszead(int x, int y)
    {
      return x + y;
    }

    static double Osztas(int x, int y)
    {
      return (double)x / y;
    }


    static void Main(string[] args)
    {
      int a, b;
      Console.Write("Kérek egy számot: ");
      a = Convert.ToInt32(Console.ReadLine());

      Console.Write("Kérek egy másik számot: ");
      b = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("{0}+{1}={2}",a,b,Osszead(a,b));
      Console.WriteLine("{0}+{1}={2:N4}", a, b, Osztas(a, b));

      Console.ReadKey();
    }
  }
}
