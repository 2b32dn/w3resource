using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsiusToKelvinAndFahrenheit {
  internal class Program {
    static void Main(string[] args) {

      double celsius, kelvin, fahrenheit;
      Console.WriteLine("Enter the amount of celsius: ");
      celsius = Convert.ToInt32(Console.ReadLine());

      kelvin = celsius + 273.15;
      fahrenheit = ((celsius * 1.8) + 32);

      Console.WriteLine($"Kelvin: {kelvin}");
      Console.WriteLine($"Fahrenheit: {fahrenheit}");
    }
  }
}
