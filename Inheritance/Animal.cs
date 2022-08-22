using System;

namespace Inheritance
{
    internal class Animal
    {
        public bool IsMammel { get; set; }
        public int NumberOfLegs { get; set; }
        public string DateOfBirth { get; set; }
        public string Diet { get; set; }

        public void PrintAnimalInfo()
        {
            if (IsMammel == true)
            {
                Console.WriteLine("This is a mammel");
            }
            else
            {
                Console.WriteLine("This is not a mammel");
            }
            Console.WriteLine($"This animal has {NumberOfLegs} legs");
            Console.WriteLine($"This animal was born {DateOfBirth}");
            Console.WriteLine($"This animal eats {Diet}");
        }

    }
}
