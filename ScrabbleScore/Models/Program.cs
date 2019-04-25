using System;

namespace Scrabble.Words
{
  public class ScrabbleProgram
  {
    public static void Main()
    {
      ScrabbleScore newScore = new ScrabbleScore();
      Console.WriteLine("Please Enter a word: ");
      string scrabbleWord = Console.ReadLine().ToLower();
      int wordScore = newScore.LoopThroughWord(scrabbleWord);
      Console.WriteLine("Your word is worth" + " " + wordScore + " " +  "points.");

    }
  }
}
