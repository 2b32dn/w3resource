using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveCharacterByIndex {
  internal class Program {
    static void Main(string[] args) {
      Console.WriteLine("Write a word: ");
      string str = Console.ReadLine();
      Console.WriteLine("Enter a index within the word: ");
      int index = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine(str.Remove(index,1));
    }
  }
}
