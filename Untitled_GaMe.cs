using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Untitled_GaMe
{
  class Program
  {
    static void Main()
    {
      string CharacterName;
      Console.WriteLine("Hello! Welcome to Untitled_GaMe! I'm Clyde."); 
      Console.ReadKey();
      Console.WriteLine("Now, I need your name. Enter it here: ");
      
      CharacterName = Console.ReadLine();

      Console.WriteLine("Oh! Hi " + CharacterName + "!\n\n");
      Console.ReadKey();
      Console.WriteLine("The creator of this game, NTBeta, thanks you for downloading the game! Anyways, I hope you enjoy it!");
    }
  }
}
