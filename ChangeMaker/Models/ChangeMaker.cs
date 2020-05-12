using System;
using System.Collections.Generic;

namespace ChangeMaker.Models
{
  class ChangeMaker
  {
    public static decimal input { get; set; }
    public static List<int> quarters = new List<int>{};
    public static List<int> dimes = new List<int>{};
    public static List<int> nickles = new List<int>{};
    public static List<int> pennies = new List<int>{};

    public static void GetInput(decimal input)
    {
      Input = decimal.Parse(input);
    }

    public static void ChangeIt(decimal input)
    {
      int coinCount = input * 100;
      for (int i = coinCount; i>0; i--)
      {
        if (i % 25 == 0)
        {
          quarters.Add(i);
        }
      }
    }
  }
}
   