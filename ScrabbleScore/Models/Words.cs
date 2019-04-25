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

    public static Dictionary<char, int> scrabbleValues = new Dictionary<char, int>()
    {
      {'a', 1},
      {'b', 3},
      {'c', 3},
      {'d', 2},
      {'e', 1},
      {'f', 4},
      {'g', 2},
      {'h', 4},
      {'i', 1},
      {'j', 8},
      {'k', 5},
      {'l', 1},
      {'m', 3},
      {'n', 1},
      {'o', 1},
      {'p', 3},
      {'q', 10},
      {'r', 1},
      {'s', 1},
      {'t', 1},
      {'u', 1},
      {'v', 4},
      {'w', 4},
      {'x', 8},
      {'y', 4},
      {'z', 10}
    };

    public int LookUpValue(char letter)
    {
      return scrabbleValues[letter];
    }

    public int LoopThroughWord(string word){
      char[] wordArray = word.ToCharArray();
      int score = 0;
    for (int i = 0; i <= wordArray.Length - 1; i++)
    {
      score += LookUpValue(wordArray[i]);
    }
    return score;
    }
  }
}
