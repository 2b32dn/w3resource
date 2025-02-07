using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageOfFourNumbers {
  internal class Program {
    static void Main(string[] args) {
      int num1, num2, num3 , num4 ;
      Console.WriteLine("Enter the First number: ");
      num1 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter the Second number: ");
      num2 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter the Third number: ");
      num3 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter the Fourth number: ");
      num4 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine($"The average of {num1}, {num2}, {num3}, {num4} is {(num1 + num2 + num3 + num4) / 4}");
    }
  }
}
