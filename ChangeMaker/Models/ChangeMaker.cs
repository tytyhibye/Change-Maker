using System;
using System.Collections.Generic;

namespace ChangeMaker.Models
{
  public class ChangeBack
  {
    public static decimal Input { get; set; }
    public static int Quarters { get;set; }
    public static int Dimes { get; set; }
    public static int Nickles { get; set; }
    public static int Pennies { get; set; }

    public static void GetInput(string input)
    {
      Input = decimal.Parse(input);
    }

    public static void ChangeIt(decimal input)
    {
      decimal coinCount = input * 100;
      for (decimal i = coinCount; i>0; i--)
      {
        if (i % 25 == 0)
        {
          Quarters++;
        }
      }
    }
  }
}
   