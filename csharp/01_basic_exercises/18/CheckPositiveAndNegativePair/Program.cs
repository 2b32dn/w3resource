using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPositiveAndNegativePair {
  internal class Program {
    static void Main(string[] args) {
      Console.WriteLine("Insert the first integer: ");
      int num1 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Insert the second integer: ");
      int num2 = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine(CheckPositivePair(num1, num2));
    }

    public static Boolean CheckPositivePair(int num1, int num2) {
      return (num1 < 0 || num2 < 0) ? true: false;
    }
  }
}
