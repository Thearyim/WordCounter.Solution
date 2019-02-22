using System.IO;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using WordCount.Models;

namespace WordCount
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Please enter any sentences and have the words counted: ");
      string userText = Console.ReadLine();
      WordCounter wordCounter = new WordCounter();
      Dictionary<string, int> result = wordCounter.GetWordCount(userText);
      Console.WriteLine("WordCounted: " + result);
    }
  }
}
