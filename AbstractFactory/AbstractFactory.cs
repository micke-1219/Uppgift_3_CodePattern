using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory
{
    public class AbstractFactory
    {
        public IAnimalFactory Factory(string animal)
        {
            switch (animal)
            {
                case "dog":
                    DogFactory dogFactory = new();
                    return dogFactory;
                case "cat":
                    CatFactory catFactory = new();
                    return catFactory;
                default:
                    break;
            }
            return null;
        }
    }
}
