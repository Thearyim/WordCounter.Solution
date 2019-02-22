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
    public ActionResult Create(string wordDictionary)
    {

      WordCount myWordCount = new WordCount(wordDictionary);
      return View("Index", myWordCount);
    }
  }
}
