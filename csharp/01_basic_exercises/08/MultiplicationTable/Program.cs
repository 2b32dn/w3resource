﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable {
  internal class Program {
    static void Main(string[] args) {
      Console.WriteLine("Enter the number: ");
      int num = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Expected Output: ");

      for (int i = 0; i <= 10; i++) {
        Console.WriteLine($"{num} * {i} = {num * i}");
      }
    }
  }
}
