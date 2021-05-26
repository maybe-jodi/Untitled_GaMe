using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello! Welcome to Untitled_GaMe! I'm Clyde. What's your name?"); 
      
      Console.WriteLine("Enter username:");

      //Create a string variable and get user input from the keyboard and store it in the variable
      string Input1 = Console.ReadLine();

      // Print the value of the variable (userName), which will display the input value
      Console.WriteLine("Oh! Hi {0}",Input1);
    }
  }
}
