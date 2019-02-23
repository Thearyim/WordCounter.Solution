using System.Collections.Generic;
using System;

namespace WordCount.Models
{
  public class WordCounter
  {
    private string wordText;

    public WordCounter(string text)
    {
      this.wordText = text;
    }
    public string GetWordCount()
    {

      //create a dictionary which takes in strings and int
      string wordCountString = "";
      Dictionary<string, int> wordCounts = new Dictionary<string, int>();

      //split sentence into strings of words
      //remove space between words
      char[] wordDelimiters = new char[]{' '};
      string[] words = this.wordText.Split(wordDelimiters, StringSplitOptions.RemoveEmptyEntries);

      //forEach word in words
      foreach(string word in words)
      {
        string wordLc = word.ToLower();
        if (wordCounts.ContainsKey(wordLc))
        {
          wordCounts[wordLc]++;
        }
        else
        {
          wordCounts.Add(wordLc, 1);
        }
      }

      foreach (var entry in wordCounts)
      {
        wordCountString += $"{entry.Key}: {entry.Value}<br/>";
      }

      return wordCountString;
    }
  }
}
