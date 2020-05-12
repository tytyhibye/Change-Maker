using System;
using System.Collections.Generic;

namespace ChangeMaker.Models
{
  public class ChangeBack
  {
    public static decimal Input { get; set; }
    public static int Quarters { get;set; }
    public static int Dimes { get; set; }
    public static int Nickels { get; set; }
    public static int Pennies { get; set; }

    public static void GetInput(string input)
    {
      Input = decimal.Parse(input);
      // ChangeIt(Input);
    }

    public static void ChangeIt()
    {
      int coinCount = Convert.ToInt32(Input* 100);
      Quarters = coinCount / 25;
      int DimesMath = coinCount % 25;
      Dimes = DimesMath / 10;
      int NickelsMath = DimesMath % 10;
      Nickels = NickelsMath / 5;
      Pennies = NickelsMath % 5;
         
        }
      }
    }


   