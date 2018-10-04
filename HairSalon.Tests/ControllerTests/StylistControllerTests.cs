using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using HairSalon.Controllers;
using HairSalon.Models;




[TestMethod]
        public void Create_ReturnsCorrectActionType_RedirectToActionResult()
        {
            //Arrange
            ItemsController controller = new ItemsController();

            //Act
            IActionResult view = controller.Create("Walk the dog");

            //Assert
            Assert.IsInstanceOfType(view, typeof(RedirectToActionResult));
        }
