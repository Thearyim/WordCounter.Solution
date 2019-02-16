using System.Collections.Generic;
using System;

namespace WordCount.Models
{
  public class WordCounter
  {
    public Dictionary<string, int> GetWordCount(string sentence)
    {
      //gathers both a word and sentence from a user
      //then checks how frequently the word appears
      //in the sentence
      //i.e. Put the garbage out for the garbage truck
      //the: 2
      //garbage: 2
      //put: 2

      //create a dictionary which takes in strings and int
      Dictionary<string, int> wordDictionary = new Dictionary<string, int>();

      //split sentence into strings of words
      //remove space between words
      char[] wordDelimiters = new char[]{' '};
      string[] words = sentence.Split(wordDelimiters, StringSplitOptions.RemoveEmptyEntries);

      //forEach word in words
      foreach(string word in words)
      {
        string wordLc = word.ToLower();
        if (wordDictionary.ContainsKey(wordLc))
        {
          wordDictionary[wordLc]++;
        }
        else
        {
          wordDictionary.Add(wordLc, 1);
        }
      }

      return wordDictionary;
    }
  }
}
