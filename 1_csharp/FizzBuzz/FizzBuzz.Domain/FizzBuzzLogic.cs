using System;
namespace FizzBuzz.Domain
{
  public class FizzBuzzLogic
  {
    public void CountAndTest(int top, int first, int second)
    {
      int count = 0;
      int totalFizz = 0;
      int totalBuzz = 0;
      int totalFizzBuzz = 0;
      if (top > 0)
      {
        while (count <= top)
        {
          int fizz = CheckFizz(count, first);
          int buzz = CheckBuzz(count, second);
          totalFizz += fizz;
          totalBuzz += buzz;
          if (fizz == 1 && buzz == 1){
            totalFizzBuzz += 1;
          }
          count++;
        }
      }
      System.Console.WriteLine("There were " + totalFizz + " Fizzes and " + totalBuzz + " Buzzes and " + totalFizzBuzz + " FuzzBuzzes.");
    }
    public int CheckFizz(int num, int fizzNum)
    {
      return Convert.ToInt32(num % fizzNum == 0);
    }

    public int CheckBuzz(int num, int buzzNum)
    {
      return Convert.ToInt32(num % buzzNum == 0);
    }
    public string SanitizeInput(int limit, int first, int second)
    {
      if (limit < 0) { limit = 0; }
      if (first < 0) { first = 0; }
      if (second < 0) { second = 0; }
      return "Running FizzBuzz with a limit of " + limit + " a first modulus of " + first + ", and second modulus of " + second + ".";
    }
  }
}