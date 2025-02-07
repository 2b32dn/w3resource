using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapTwoNumbers {
  internal class Program {
    static void Main(string[] args) {

      int num1, num2, temp;

      Console.WriteLine("Swap two numbers");
      Console.WriteLine("Input the First number:");
      num1 = int.Parse(Console.ReadLine());
      Console.WriteLine("Input the Second number:");
      num2 = int.Parse(Console.ReadLine());

      Console.WriteLine($"Before Swapping: {num1}, {num2}");

      temp = num1;
      num1 = num2;
      num2 = temp;

      Console.WriteLine($"After Swapping: {num1}, {num2}");
    }
  }
}
