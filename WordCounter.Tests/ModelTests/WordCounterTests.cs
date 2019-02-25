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
        string text = "put the garbage out for the garbage truck";
        WordCounter testWordCounter = new WordCounter(text);
        Dictionary<string, int> result = testWordCounter.GetWordCount();
        Assert.AreEqual(1, result["put"]);
        Assert.AreEqual(2, result["the"]);
        Assert.AreEqual(2, result["garbage"]);
      }

      [TestMethod]
      public void GetWordCount_WordCountedFullWordOnly_True()
      {
        string text = "put the garbage along with other garbages out for the garbage truck";
        WordCounter testWordCounter = new WordCounter(text);
        Dictionary<string, int> result = testWordCounter.GetWordCount();
        Assert.AreEqual(1, result["put"]);
        Assert.AreEqual(2, result["the"]);
        Assert.AreEqual(2, result["garbage"]);
      }

      [TestMethod]
      public void GetWordCount_IsNotCaseSensitive()
      {
        string text = "Put the garbage out for the Garbage Truck.";
        WordCounter testWordCounter = new WordCounter(text);
        Dictionary<string, int> result = testWordCounter.GetWordCount();
        Assert.AreEqual(1, result["put"]);
        Assert.AreEqual(2, result["the"]);
        Assert.AreEqual(2, result["garbage"]);
      }

      [TestMethod]
      public void GetWordCount_HandlesExtraWhiteSpace()
      {
        string text = "Put the garbage  out for the Garbage Truck.";
        WordCounter testWordCounter = new WordCounter(text);
        Dictionary<string, int> result = testWordCounter.GetWordCount();
        Assert.AreEqual(1, result["put"]);
        Assert.AreEqual(2, result["the"]);
        Assert.AreEqual(2, result["garbage"]);
      }

      [TestMethod]
      public void GetWordCountHtml_FormatsTextWithASingleWordCorrectly()
      {
        string text = "garbage";
        WordCounter testWordCounter = new WordCounter(text);
        string result = testWordCounter.GetWordCountHtml();
        Assert.AreEqual("garbage: 1<br/>", result);
      }

      [TestMethod]
      public void GetWordCountHtml_FormatsTextWithMultipleWordsCorrectly()
      {
        string text = "garbage truck";
        WordCounter testWordCounter = new WordCounter(text);
        string result = testWordCounter.GetWordCountHtml();
        Assert.AreEqual("garbage: 1<br/>truck: 1<br/>", result);
      }
    }
}
