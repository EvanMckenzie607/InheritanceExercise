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




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird penguin = new Bird();
            penguin.IsMammel = true;
            penguin.DateOfBirth = "Last week or something... i dunno im trying to learn code";
            penguin.NumberOfLegs = 2;
            penguin.Diet = "Fish";
            penguin.DoesItFly = false;
            penguin.IsItNocturnal = false;
            penguin.Colors = "Black & White";
            penguin.RegionBirdIsFrom = "The North Pole";

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile mystery = new Reptile();
            mystery.IsMammel = false;
            mystery.DateOfBirth = "17 years ago on a cold winter night";
            mystery.NumberOfLegs = 0;
            mystery.Diet = "People";
            mystery.DoesItSwim = false;
            mystery.IsItVenomous = true;
            mystery.LengthOfReptile = "Two School Busses";
            mystery.IsItADragon = true;

            penguin.PrintAnimalInfo();
            penguin.PrintBird();
            Console.WriteLine("Perhaps this is a Penguin!");
            Console.WriteLine("");
            Console.WriteLine("Okay, Next!");
            Console.WriteLine("");
            mystery.PrintAnimalInfo();
            Console.WriteLine("");
            mystery.PrintReptile();






        }
    }
}
