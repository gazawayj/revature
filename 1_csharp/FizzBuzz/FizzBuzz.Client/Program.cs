using System;
using FizzBuzz.Domain;

namespace FizzBuzz.Client
{
  class Program
  {
    static void Main(string[] args)
    {
      FizzBuzzLogic fbt = new FizzBuzzLogic();
      int limit = 0;
      int first = 0;
      int second = 0;
      System.Console.WriteLine("Enter your limit:");
      var limitString = Console.ReadLine();
      System.Console.WriteLine("Enter the first modulus:");
      var firstString = Console.ReadLine();
      System.Console.WriteLine("Enter the second modulus:");
      var secondString = Console.ReadLine();
      limit = Convert.ToInt32(limitString);
      first = Convert.ToInt32(firstString);
      second = Convert.ToInt32(secondString);
      System.Console.WriteLine(fbt.SanitizeInput(limit, first, second));
      fbt.CountAndTest(limit, first, second);
    }
  }
}
