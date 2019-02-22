using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using WordCount.Models;

namespace WordCount.Controllers
{
  public class WordCountController : Controller
  {
    [HttpGet("/wordcount")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/wordcount/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/wordcount")]
    public ActionResult Create(string text)
    {

      WordCounter myWordCount = new WordCounter();
      Dictionary<string, int> wordCount = myWordCount.GetWordCount(text);

      return View("Index", wordCount);
    }
  }
}
