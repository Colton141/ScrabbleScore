using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Words;

namespace Scrabble.Tests
{
  [TestClass]
  public class ScrabbleScoreTest
  {
    // [TestMethod]
    // public void IsWord_IsAWord_True()
    // {
    //   ScrabbleScore newWord = new ScrabbleScore();
    //   Assert.AreEqual(true, newWord.IsWord("test"));
    // }

    // [TestMethod]
    // public void WorthOne_LetterAEqualsOne_True()
    // {
    //   ScrabbleScore newWord = new ScrabbleScore();
    //   Assert.AreEqual(1, newWord.WorthOne("a"));
    // }

    [TestMethod]
    public void WorthOne_LetterAEqualsOne_True()
    {
      ScrabbleScore newWord = new ScrabbleScore();
      Assert.AreEqual(1,  newWord.LookUpValue('a'));
    }

    [TestMethod]
    public void WorthFive_WordEqualsFive_True()
    {
      ScrabbleScore newWord = new ScrabbleScore();
      Assert.AreEqual(5,  newWord.LoopThroughWord("dad"));
    }

  }
}



// ______________________________________________________
// Words.cs
//
// // using System;
// // using System.Collections.Generic;
//
// namespace Scrabble.Words
// {
//   public class ScrabbleScore
//   {
//     // private string _word;
//     // public bool IsWord(string word)
//     // {
//     // _word = word;
//     // return _word == word;
//     // }
//     // public int WorthOne(string letter)
//     // {
//     // if (letter == "a")
//     // {
//     //   return 1;
//     // }
//     // else
//     // {
//     //   return 0;
//     // }
//     // }
//   }
// }
