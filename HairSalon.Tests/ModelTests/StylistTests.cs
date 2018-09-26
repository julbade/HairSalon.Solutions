using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using HairSalon.Models;
using Microsoft.AspNetCore.Mvc;

namespace HairSalon.Test
{
  [TestClass]
    public class StylistTests : IDisposable
    {
        public void Dispose()
        {
            Stylist.DeleteAll();
        }
        public StylistTests()
        {
            DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=julius_bade_test;";
        }

      [TestMethod]
      public void GetAll_DbStartsEmpty_0()
      {
        //Arrange
        //Act
        int result = Stylist.GetAll().Count;

      //Assert
      Assert.AreEqual(0, result);
      }


      [TestMethod]
      public void Equals_ReturnsTrueIfNamesAreTheSame_Stylist()
      {
        // Arrange, Act
        Stylist firstStylist = new Stylist("Name");
        Stylist secondStylist = new Stylist("Name");

        // Assert
        Assert.AreEqual(firstStylist, secondStylist);
      }
      [TestMethod]
      public void Save_SavesToDatabase_StylistList()
      {
        //Arrange
        Stylist testStylist = new Stylist("Name");

        //Act
        testStylist.Save();
        List<Stylist> result = Stylist.GetAll();
        List<Stylist> testList = new List<Stylist>{testStylist};

        //Assert
        CollectionAssert.AreEqual(testList, result);
      }


        [TestMethod]
        public void Save_AssignsIdToObject_Id()
        {
          //Arrange
          Stylist testStylist = new Stylist("Name");

          //Act
          testStylist.Save();
          Stylist savedStylist = Stylist.GetAll()[0];

          int result = savedStylist.GetId();
          int testId = testStylist.GetId();

          //Assert
          Assert.AreEqual(testId, result);
        }



  }
}
