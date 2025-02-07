using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideTwoNumbers {
  internal class Program {
    static void Main(string[] args) {
      Console.WriteLine("Let's divide two integers");
      Console.WriteLine("Insert the first integer");
      double num1 = double.Parse(Console.ReadLine());
      Console.WriteLine("Insert the second integer");
      double num2 = double.Parse(Console.ReadLine());

      double total = num1 / num2;
      
      Console.WriteLine(total);
    }
  }
}
