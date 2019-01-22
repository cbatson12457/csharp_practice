using System;

namespace VSTEST{
class oneTwo{
  public static void Main (string[] args) {

    Console.WriteLine ("Enter length of rectangle: ");
    int length = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine ("Enter width of rectangle: ");
    int width = Convert.ToInt32(Console.ReadLine());

    int area = length * width;

    Console.WriteLine("The area of the rectangle is: " + area);
  }
}
}