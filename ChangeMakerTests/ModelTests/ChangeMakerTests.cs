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
      ChangeMaker testOne = new ChangeMaker();

      // Act
      ChangeMaker.GetInput("50");

      // Assert
      Assert.AreEqual(typeof(decimal), ChangeMaker.Input.GetType());
    }
  }
}