using System;

namespace VSTEST
{
class oneThree {
  public static void Main (string[] args) {

    Console.WriteLine ("Enter number of miles drive: ");
    int miles = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine ("Enter gallons of gas consumed: ");
    int gallons = Convert.ToInt32(Console.ReadLine());

    int mpg = miles / gallons;

    Console.WriteLine("The miles per gallon: " + mpg);

  }
}
}