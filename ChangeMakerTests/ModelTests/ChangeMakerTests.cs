using System;
using System.Collections.Generic;
using ChangeMaker.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChangeMaker.TestTools
{
  [TestClass]
  public class ItemTests : IDisposable
  {
    public void Dispose()
    {

    }
    [TestMethod]
    public void UserInput_IsUserInputADecimal_True()
    {
      // Arrange
      ChangeBack testOne = new ChangeBack();

      // Act
      ChangeBack.GetInput(".87");

      // Assert
      Assert.AreEqual(typeof(decimal), ChangeBack.Input.GetType());
    }

    [TestMethod]
    public void ChangeIt_ReturnsQuartersFirst_True()
    {
      // Arrange
      ChangeBack testTwo = new ChangeBack();

      // Act
      ChangeBack.GetInput(".90");
      ChangeBack.ChangeIt();

      // Assert
      Assert.AreEqual(3, ChangeBack.Quarters);
    }

    [TestMethod]
    public void ChangeIt_ReturnsDimesNext_True()
    {
      // Arrange
      ChangeBack testThree = new ChangeBack();

      // Act
      ChangeBack.GetInput(".90");
      ChangeBack.ChangeIt();
      
      // Assert
      Assert.AreEqual(1, ChangeBack.Dimes);
    }

    [TestMethod]
    public void ChangeIt_ReturnsNickelsNext_True()
    {
      // Arrange
      ChangeBack testFour = new ChangeBack();
      
      // Act
      ChangeBack.GetInput(".90");
      ChangeBack.ChangeIt();

      // Assert
      Assert.AreEqual(1, ChangeBack.Nickels);

    }
    [TestMethod]
    public void ChangeIt_ReturnsPenniesLast_True()
    {
      ChangeBack testFive = new ChangeBack();
      ChangeBack.GetInput(".99");
      ChangeBack.ChangeIt();

      Assert.AreEqual(4, ChangeBack.Pennies);
    }
  }
}