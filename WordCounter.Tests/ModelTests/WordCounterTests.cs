using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordCount.Models;

namespace WordCount.Tests
{
    [TestClass]
    public class WordCounterTest
    {
      [TestMethod]
      public void GetWordCount_WordCounted_True()
      {
        WordCounter testWordCounter = new WordCounter();
        Dictionary<string, int> result = testWordCounter.GetWordCount("put the garbage out for the garbage truck");
        Assert.AreEqual(1, result["put"]);
        Assert.AreEqual(2, result["the"]);
        Assert.AreEqual(2, result["garbage"]);
      }

      [TestMethod]
      public void GetWordCount_IsNotCaseSensitive()
      {
        WordCounter testWordCounter = new WordCounter();
        Dictionary<string, int> result = testWordCounter.GetWordCount("Put the garbage out for the Garbage Truck.");
        Assert.AreEqual(1, result["put"]);
        Assert.AreEqual(2, result["the"]);
        Assert.AreEqual(2, result["garbage"]);
      }
    }
}
