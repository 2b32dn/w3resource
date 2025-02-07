using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticOperations {
  internal class Program {
    static void Main(string[] args) {

      int num1, num2;
      Console.WriteLine("Input the first number: ");
      num1 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Input the second number: ");
      num2 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Expected Output: ");
      Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
      Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
      Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
      Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
      Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
    }
  }
}
