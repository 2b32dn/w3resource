using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyThreeNumbers {
  internal class Program {
    static void Main(string[] args) {
      int num1, num2, num3, total;

      Console.WriteLine("Multiply 3 numbers");
      Console.WriteLine("Insert the first number: ");
      num1 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Insert the second number: ");
      num2 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Insert the third number: ");
      num3 = Convert.ToInt32(Console.ReadLine());

      total = num1 * num2 * num3;

      Console.WriteLine($"Total: {total}");
    }
  }
}
