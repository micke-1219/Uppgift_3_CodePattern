using System;
using System.Collections.Generic;

namespace Assignment2.StateCommandMemento
{
    internal class SCMMain
    {
        /*
         * Skapa en maskin som kan vara av eller på. !Använd State Pattern!
         * Om man ger den ett kommando när den är av så ska den spara det kommandot och sen köra alla sparade kommandon när den sätts på. !Använd Command Pattern!
         * Kommandot ska vara att skriva ut en sträng text som användaren anger.
         * Det ska också finnas en reset funktion som tar bort alla sparade kommandon och stänger av maskinen. !Använd Memento Pattern!
         */
        public void Run()
        {
            Machine machine = new();
            bool breakFlag = true;
            List<string> printList = new();

            Console.WriteLine("Press ENTER to turn the machine on/off, Press P to print out text, R to reset commands or press Esc to exit");
            while (breakFlag)
            {
                var choice = Console.ReadKey(true);
                switch (choice.Key)
                {
                    case ConsoleKey.Enter:
                        machine.PowerSwitch();
                        if(machine.machineState is MachineOnState)
                        {
                            if(printList.Count > 0)
                            {
                                Console.WriteLine("Printing out input that where entered in off state:");
                            }
                            foreach (var item in printList)
                            {
                                Console.WriteLine(item);
                            }
                            printList.Clear();
                        }
                        break;
                    case ConsoleKey.Escape:
                        breakFlag = false;
                        break;
                    case ConsoleKey.P:
                        Console.WriteLine("Enter the text you want to print out:");
                        string input = Console.ReadLine();
                        if(machine.machineState is MachineOnState)
                        {
                            Console.WriteLine(input);
                        }
                        else
                        {
                            Console.WriteLine("Your input will be printed when the machine is turned on");
                            printList.Add(input);
                        }
                        break;
                    case ConsoleKey.R:
                        Console.WriteLine("All commands were deleted");
                        printList.Clear();
                        if (machine.machineState is MachineOnState)
                        {
                            machine.PowerSwitch();
                        }
                        break;
                    default:
                        Console.WriteLine("Wrong key!");
                        break;
                }
            }
        }
    }
}