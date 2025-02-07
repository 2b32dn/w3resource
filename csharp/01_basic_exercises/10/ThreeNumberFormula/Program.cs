using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeNumberFormula {
  internal class Program {
    static void Main(string[] args) {
      int num1, num2, num3, f1, f2;

      Console.WriteLine("Enter the first integer");
      num1 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter the second integer");
      num2 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter the third integer");
      num3 = Convert.ToInt32(Console.ReadLine());

      f1 = (num1 + num2) * num3;
      f2 = num1 * num2 + num2 * num3;

      Console.WriteLine($"{num1},{num2},{num3} (x+y).z is {f1} and x.y + y.z is {f2}");
    }
  }
}
