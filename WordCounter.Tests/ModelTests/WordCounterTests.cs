using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        int result = testWordCounter.GetWordCount("put the garbage out for the garbage truck");
        Assert.AreEqual(put:1, the:2, garbage:2, result);
      }
    }
}
