using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatedNumberInRows {
  internal class Program {
    static void Main(string[] args) {
      Console.WriteLine("Enter a integer");
      int num = Convert.ToInt32(Console.ReadLine());
      for (int i = 0; i < 4; i++) {
        Console.WriteLine((i == 0 || i == 2) ? $"{num} {num} {num} {num}": $"{num}{num}{num}{num}");
      }
    }
  }
}
