using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Facade
{
    class FacadeMain
    {
       public void Run()
        {
            Facade facade = new Facade();
            bool breakFlag = true;

            while (breakFlag)
            {
                Console.WriteLine("Press S to save a word, L to load a word or C to continue");
                var choice = Console.ReadKey(true);
                switch (choice.Key)
                {
                    case ConsoleKey.C:
                        breakFlag = false;
                        break;
                    case ConsoleKey.L:
                        facade.LoadWord();
                        break;
                    case ConsoleKey.S:
                        facade.SaveWord();
                        break;
                    default:
                        Console.WriteLine("Wrong key!");
                        break;
                }
            }
        }
    }
}
