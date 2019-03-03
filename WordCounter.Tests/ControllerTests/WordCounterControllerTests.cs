using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCount.Controllers;
using WordCount.Models;

namespace WordCount.Tests
{
    [TestClass]
    public class WordCountControllerTest
    {

        [TestMethod]
        public void Create_RedirectsToCorrectAction_Index()
        {
            //Arrange
            WordCountController controller = new WordCountController();
            ViewResult actionResult = controller.Create("put the garbage along with other garbages out for the garbage truck") as ViewResult;
            Assert.IsNotNull(actionResult);

            //act
            string result = actionResult.ViewName;

            //assert
            Assert.AreEqual(result, "Index");
        }
    }
}
