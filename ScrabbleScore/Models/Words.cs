using System;
using System.Collections.Generic;

namespace Scrabble.Words
{
  public class ScrabbleScore
  {
    // private string _word;
    // public bool IsWord(string word)
    // {
    // _word = word;
    // return _word == word;
    // }
    // public int WorthOne(string letter)
    // {
    // if (letter == "a")
    // {
    //   return 1;
    // }
    // else
    // {
    //   return 0;
    // }
    // }

    public static Dictionary<string, int> scrabbleValues = new Dictionary<string, int>()
    {
      {"a", 1},
      {"b", 3},
      {"c", 3},
      {"d", 2},
      {"e", 2},
      {"f", 2},
      {"g", 2},
      {"h", 2},
      {"i", 2},
      {"j", 2},
      {"k", 2},
      {"l", 2},
      {"m", 2},
      {"n", 2},
      {"o", 2},
      {"p", 2},
      {"q", 2},
      {"r", 2},
      {"s", 2},
      {"t", 2},
      {"u", 2},
      {"v", 2},
      {"w", 2},
      {"x", 2},
      {"y", 2},
      {"z", 2}
    };

    public int LookUpValue(string letter)
    {
      return scrabbleValues[letter];
    }

  }
}
