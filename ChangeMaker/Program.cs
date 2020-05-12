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
      Console.WriteLine("Welcome to the Change-Machine!\n\nEnter an Amount in change and we'll break it down to it's smallest number of coins possible:");
      string input = Console.ReadLine();
      ChangeBack.GetInput(input);
      ChangeBack.ChangeIt();
      Console.WriteLine("Your change consists of:\n" + ChangeBack.Quarters + " quarters\n" + ChangeBack.Dimes + " dimes\n" + ChangeBack.Nickels + " nickels\n" + ChangeBack.Pennies + " pennies");
      Console.WriteLine("Keep the change ya filthy animal.");
    }
  }
}