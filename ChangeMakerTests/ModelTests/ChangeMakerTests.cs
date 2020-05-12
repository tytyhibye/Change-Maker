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
      ChangeBack.GetInput("50");

      // Assert
      Assert.AreEqual(typeof(decimal), ChangeBack.Input.GetType());
    }
  }
}