using System;

class DoubleIt
{
  static void Main()
  {
    Console.WriteLine("Give me a number and I will double it for you!");
    int yourNumber = Console.ReadLine();
    int yourDoubledNumber = yourNumber * 2;
    Console.WriteLine("Your doubled number is " + yourDoubledNumber);
  }
}