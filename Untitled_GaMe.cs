using System;

namespace Untitled_GaMe
{
  class Program
  {
    static void Main(string[] args)
    {
      string Input1;
      Console.WriteLine("Hello! Welcome to Untitled_GaMe! I'm Clyde. What's your name?"); 
      
      Console.WriteLine("Enter username:");
      
      Input1 = Console.ReadLine();

      Console.WriteLine("Oh! Hi {0}",Input1);
    }
  }
}

