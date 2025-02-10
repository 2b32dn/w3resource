using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddFirstCharacterFrontBack {
  internal class Program {
    static void Main(string[] args) {
      Console.WriteLine(AddFirstCharFrontBack("epik high"));
    }
    public static string AddFirstCharFrontBack (string str) {
      string firstChar = str[0].ToString();

      return str.Length > 1 ? firstChar + str + firstChar : str;
    }
  }
}
