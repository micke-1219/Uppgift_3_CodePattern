using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory
{
    public class CatFactory : IAnimalFactory
    {
        public IAnimal CreateAnimal()
        {
            Console.WriteLine("Enter the cats name:");
            string name = Console.ReadLine();
            Cat cat = new(name);
            Console.WriteLine($"A cat with the name {name} has been created!");
            return cat;
        }
    }
}
