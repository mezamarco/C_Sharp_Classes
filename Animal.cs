using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{

    //Declare: abstract class Animal, if this is an abstract class.
    //Be sure to declare virtual function, if we are dealing with method overidding.
    //To review watch: https://www.youtube.com/watch?v=RaHm_pSxqLY
    //If we want a pure virtual function, we need to declare it as an abstract method
    //In the sub-classes, we need to virtual methods and  abstract methods
    //By stating: override, to the given method.

    class Animal
    {
        //Two ways to declare getters and setters
        protected string name;
        //Note the uppercase
        public string Name
        {
            get { return name; }
            set{ this.name = value; }
        }


        protected double height;
        public double Height
        {
            get { return height; }
            set { this.height = value; }
        }


        protected double weight;
        public double Weight
        {
            get { return weight; }
            set { this.weight = value; }
        }
        protected string sound;
        public string Sound
        {
            get { return sound; }
            set { this.sound = value; }
        }


        //Constructor
        public Animal() {
            this.height = 0;
            this.weight = 0;
            this.sound = "No Sound";
            this.name = "No Name";

            ++animalCounter;
        }

        //Custom Constructor
        public Animal(double height, double weight, string name, string sound) {
            this.height = height;
            this.weight = weight;
            this.sound = name;
            this.name = sound;

            ++animalCounter;
        }



        public static int animalCounter = 0;
        public static int getAnimalCounter() {
            return animalCounter;
        }


        public string toString() {
            return $"Name: {name} Height: {height} Weight: {weight} Sound: {sound}";
        }




    }
}

