using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Untitled_GaMe
{
  class Game
    {
    }
    class Item
    {
    }
  class Program
  {
    static void Main()
    {
      Console.Title = "Untitled_GaMe - Press Enter";
      Console.WriteLine("Press Enter");

   ConsoleKeyInfo key = Console.ReadKey();

   if (key.Key.Equals(ConsoleKey.Enter))
   {
    Console.WriteLine("Let's start!");
   }
      string CharacterName;
      string Cho1
      Console.Title = "Untitled_GaMe - Start";
      Console.WriteLine("Hello! Welcome to Untitled_GaMe! I'm Clyde."); 
      Console.WriteLine("Now, I need your name. Enter it here: ");
      
      CharacterName = Console.ReadLine();

      Console.WriteLine("Oh! Hi " + CharacterName + "!\n\n");
      Console.ReadKey();
      Console.WriteLine("The creator of this game, NTBeta, thanks you for downloading the game! Anyways, I hope you enjoy it!");
      Console.WriteLine("You walk into a bar. There's 2 people there, A bartender and a woman.");
      Console.WriteLine("You don't know where you are. Do you ask the bartender or the woman where you are?");
      Console.WriteLine("1 for the bartender, 2 for the woman.");
      Console.WriteLine("Choose here:")
      
      Cho1 = Console.ReadLine();
      
      if (Cho1 > 1) 
      {
      Console.WriteLine("You're in Malchovitz, off the coast of Galak.");
      Console.WriteLine("Here, take a map. I bought two earlier. Rather be safe than sorry, eh?");
      Console.WriteLine("You take the map.");
      }
    }
  }
}
