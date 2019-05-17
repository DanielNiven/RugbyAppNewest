using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using RugbyApp;
using RugbyApp.Controllers;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RugbyAppTesting
{
    [TestClass]
    public class HomeController
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();
            // Act
            ViewResult result = controller.Index() as ViewResult;
            // Assert
            Assert.

        }

    }
  
  }
