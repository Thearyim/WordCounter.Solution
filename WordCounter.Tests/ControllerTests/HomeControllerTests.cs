using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCount.Controllers;
using WordCount.Models;

namespace WordCount.Tests
{
    [TestClass]
    public class HomeControllerTest
    {

      [TestMethod]
      public void Index_ReturnsCorrectView_True()
      {
        //Arrange
        HomeController controller = new HomeController();
      
        //Act
        ActionResult indexView = controller.Index();
      
        //Assert
        Assert.IsInstanceOfType(indexView, typeof(ViewResult));
      }
      
      [TestMethod]
      public void Index_ViewContainsNoModel()
      {
        //Arrange
        ViewResult indexView = new HomeController().Index() as ViewResult;
        Assert.IsNotNull(indexView);
      
        //Act
        var result = indexView.ViewData.Model;
      
        //Assert
        Assert.IsNull(result);
      }

    }
}
