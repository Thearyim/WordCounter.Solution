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
      //gathers both a word and sentence from a user
      //then checks how frequently the word appears
      //in the sentence
      //i.e. Put the garbage out for the garbage truck
      //the: 2
      //garbage: 2
      //put: 2

      //create a dictionary which takes in strings and int
      string wordCountString = "";
      Dictionary<string, int> wordCounts = new Dictionary<string, int>();

      //split sentence into strings of words
      //remove space between words
      char[] wordDelimiters = new char[]{' '};
      string[] words = sentence.Split(wordDelimiters, StringSplitOptions.RemoveEmptyEntries);

      //forEach word in words
      foreach(var entry in wordCounts)
      {
        string wordLc = word.ToLower();
        wordCountString += $"{entry.Key}: {entry.Value}<br/>";
        if (wordDictionary.ContainsKey(wordLc))
        {
          wordDictionary[wordLc]++;
        }
        else
        {
          wordDictionary.Add(wordLc, 1);
        }
      }

      return wordCountString;
    }
  }
}
