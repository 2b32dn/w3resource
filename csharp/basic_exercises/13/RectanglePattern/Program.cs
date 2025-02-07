using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectanglePattern {
  internal class Program {
    static void Main(string[] args) {
      Console.WriteLine("Enter a number: ");
      int num = Convert.ToInt32(Console.ReadLine());
      for (int i = 0; i <= 5; i++) {
        if (i == 0 || i == 5) {
          Console.WriteLine($"{num}{num}{num}");
        } else {
          Console.WriteLine($"{num} {num}");
        }
      }
    }
  }
}
