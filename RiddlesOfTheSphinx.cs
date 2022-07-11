using System;
using System.Collections.Generic;

// namespace Sphinx
// {
//   public class RiddleNumber 
//     {
//       public string StringNumber {get; set; }
    
//     public string SetRiddleRandom()
//     {
//       Random rnd = new Random();
//       int number = rnd.Next(1 ,3);
//       string stringNumber = number.ToString();
//       return stringNumber;
//     }
//     public string GetRiddleRandom()
//     {
//       return stringNumber;
//     }
//     public RiddleNumber(string stringNumber)
//     {
//       StringNumber = stringNumber;
//     }
//   }
//   public class Program
//   {
//     public static Dictionary<string, string> riddlesBook = new Dictionary<string, string>() { { "Q1", "What runs all around the yard but never moves?"}, {"A1", "a fence"}, {"Q2", "What is it that given one, you'll have either two or none?"}, {"A2","a choice"} };

  
    
//     public static void Main()
//     {

//       RiddleNumber random = new RiddleNumber("0");

//       Console.WriteLine("Do you want to answer a riddle? ['Y' for yes, 'Enter' for no]");
//       string stringAnswer = Console.ReadLine();
//       if (stringAnswer == "Y" || stringAnswer == "y")
//       {
//         AskRiddleTwo();
//       }
//       else
//       {
//         Console.WriteLine("You've been eaten by the Sphinx!");
//       }
//     } 
//   static void AskRiddle()
//     {
//       Console.WriteLine(riddlesBook["Q1"]);
//       string riddleAnswer = Console.ReadLine();
//   if(riddleAnswer.ToLower() == riddlesBook["A1"]) 
//       {
//         Console.WriteLine("Good Job, that's correct!");
//         AskRiddleTwo();
//       } 
//       else 
//       {
//         Console.WriteLine("Keep trying");
//         AskRiddle();
//       }
//     }
//     static void AskRiddleTwo()
//     {
//       SetRiddleRandom();
//       GetRiddleRandom();
//       Console.WriteLine(riddlesBook["Q" + stringNumber]);
//       string riddleTwoAnswer = Console.ReadLine();
//       if(riddleTwoAnswer.ToLower() == riddlesBook["A"+ stringNumber])
//       {
//         Console.WriteLine("Good Job, that's correct!");
//       }
//       else 
//       {
//         Console.WriteLine("Keep Trying");
//         AskRiddleTwo(stringNumber);
//       }

//     }
    
    

//   }
// }
