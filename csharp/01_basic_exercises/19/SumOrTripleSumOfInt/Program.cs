using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOrTripleSumOfInt {
  internal class Program {
    static void Main(string[] args) {
      Console.WriteLine("Insert the first int: ");
      int a = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Insert the second int: ");
      int b = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine(SumTriple(a, b)); 
    }
    public static int SumTriple(int a, int b) {
      return a == b ? (a + b) * 3 : a + b; 
    }
  }
}
