using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapFirstAndLastCharacters {
  internal class Program {
    static void Main(string[] args) {
      string first, second;
      Console.WriteLine("Enter a word: ");
      string word = Console.ReadLine();

      if (word.Length > 1) {
        first = word[0].ToString();
        second = word[word.Length - 1].ToString();

        Console.WriteLine(second + word.Substring(1, word.Length - 2) + first);

      } else {
        Console.WriteLine(word);
      }
    }
  }
}
