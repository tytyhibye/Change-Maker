using System;
using System.Collections.Generic;
using ChangeMaker.Models;

namespace Program
{
  class ChangeFront
  {
    public static void Main()
    {
      ChangeBack changeMaker = new ChangeBack();
      Console.WriteLine("Welcome to the Change-Machine!\n\nEnter an Amount in dollars and we'll break it down into change:");
      string input = Console.ReadLine();
      ChangeBack.GetInput(input);

    }
  }
}