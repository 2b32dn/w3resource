using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTwoNumbers {
  internal class Program {
    static void Main(string[] args) {
      Console.WriteLine("Let's find the sum of two numbers.");
      Console.WriteLine("Insert the first integer");
      int num1 = int.Parse(Console.ReadLine());
      Console.WriteLine("Insert the second integer");
      int num2 = int.Parse(Console.ReadLine());

      int total = num1 + num2;

      Console.WriteLine(total);
    }
  }
}
