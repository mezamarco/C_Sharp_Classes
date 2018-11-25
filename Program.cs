using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program.cs
    {
        static void Main(string[] args)
        {
            Animal spot = new Animal(15, 10, "Spot", "Woof");

            Console.WriteLine(spot.toString());
            Console.WriteLine("\n\n");

            Console.WriteLine("Number of Animals: " + Animal.getAnimalCounter());

            //Another way to create an object
            Animal grover = new Animal
            {
                Name = "Grover",
                Height = 23,
                Weight = 25,
                Sound = "Grrrr"

            };

            Console.WriteLine("Number of Animals: " + Animal.getAnimalCounter());

            Console.WriteLine("\n\n");

            Dog myDog = new Dog(5, 7, "WoofWoof", "myDog", "Burger");
            Console.WriteLine(myDog.toString());

            //Do we have to deal with virtual functions
            //Or does the compiler know what function to call,  when dealing with method overidding.
            Animal myTempDog = new Dog(1, 2, "Waa", "myTempDog", "Pizza");


            //Oh no, we have to deal with vritual functions
            //It thinks that we are dealing with an Animal object type

            Console.WriteLine(myTempDog.toString());



            Console.WriteLine("\n\n");


        }
    }
}

