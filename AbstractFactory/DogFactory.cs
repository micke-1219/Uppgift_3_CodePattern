using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory
{
    public class DogFactory : IAnimalFactory
    {
        public IAnimal CreateAnimal()
        {
            Console.WriteLine("Enter the dogs name:");
            string name = Console.ReadLine();
            Dog dog = new(name);
            Console.WriteLine($"A dog with the name {name} has been created!");
            return dog;
        }
    }
}
