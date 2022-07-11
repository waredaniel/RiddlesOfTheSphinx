using System;
using Sphinx;

namespace Riddler {

  public class Program
  {
    public static void Main()
    {
      Riddle one = new Riddle(1, "What runs all around the yard but never moves?", "a fence");
      Riddle two = new Riddle(2, "What is it that given one, you'll have either two or none?", "a choice");

      Console.WriteLine("Do you want to answer a riddle? ['Y' for yes, 'Enter' for no]");
      string stringAnswer = Console.ReadLine();
      if (stringAnswer == "Y" || stringAnswer == "y")
      {
        // AskRiddleTwo();
        SetRiddleRandom();
      }
      else
      {
        Console.WriteLine("You've been eaten by the Sphinx!");
      }
      static void AskRiddleTwo()
      {

      }
      void SetRiddleRandom()
    {
      Random rnd = new Random();
      int number = rnd.Next(1 ,3);
      Console.WriteLine(number);
    } 
    }
  }
}