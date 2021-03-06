using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory
{
    class AbstractFactoryMain
    {
        // Skapa två fabriker som kan köra CreateAnimal() den ena fabriken ska skapa en hund och den andra en katt skapa sedan en abstract factory där man
        // får tillbaka en av de 2 fabrikerna beroende på en sträng parameter
        
        public void Run()
        {
            AbstractFactory abstractFactory = new();
            Console.WriteLine("Enter \"dog\" to create a dog or \"cat\" to create a cat");
            string animal = Console.ReadLine();
            var factory = abstractFactory.Factory(animal);
            factory.CreateAnimal();
        }
    }
}
