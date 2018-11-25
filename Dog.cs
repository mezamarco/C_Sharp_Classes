using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Dog: Animal
    {
        public string favFood { get; set; }


        //Constructor
        public Dog() : base() {
            //We are calling the base class
            this.favFood = "Steak";
        }

        public Dog(double height, double weight, string name, 
			string sound, string favFood):base( height,  weight,  name,  sound)
        {
            //We are passing the argument to the base class
            this.favFood = favFood;
        }


        //Function overidding
        public string toString()
        {
            return $"Name: {name} Height: {height} Weight: {weight} Sound: {sound} FavFood: {favFood}";
        }

    }
}

