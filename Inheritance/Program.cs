using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class

            Bird bird1 = new Bird()
            {
                Name = "George the Cardinal",
                Age = 2,
                IsHungry = true,
                Habitat =  "Woodlands and Grasslands",
                TypeOfBeak = "short, stout, and cone-shaped",
                PlumageColor = "that unforgettable red",
                InFlight = true
            };

            Console.WriteLine($"{bird1.Name} is {bird1.Age} years old. He lives in {bird1.Habitat}.\n" +
                $"His beak is {bird1.TypeOfBeak} and his feathers are {bird1.PlumageColor}.\n" +
                $"Is he hungry? {bird1.IsHungry}\n" +
                $"Is he currently flying? {bird1.InFlight}\n");

            Reptile reptile1 = new Reptile()
            {
                Name = "Princess the Komodo Dragon",
                Age = 15,
                IsHungry = true,
                Habitat = "anywhere from a tropical dry forest to a savanna to a deciduous monsoon forest",
                ScaleColors = "variety of colors including blue orange green and gray",
                TailLength = 5.2,
                IsSunBathing = true
            };

            Console.WriteLine($"{reptile1.Name} is {reptile1.Age} years old. She lives {reptile1.Habitat}.\n" +
                $"Her scales are a {reptile1.ScaleColors} and her tail is {reptile1.TailLength} feet long.\n" +
                $"Is she hungry? {reptile1.IsHungry}\n" +
                $"Is she currently sun bathing? {reptile1.IsSunBathing}");


            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
