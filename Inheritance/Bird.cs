using System;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public bool DoesItFly { get; set; }
        public string Colors { get; set; }
        public string RegionBirdIsFrom { get; set; }
        public bool IsItNocturnal { get; set; }

        public void PrintBird()
        {
            Console.WriteLine("");
            Console.WriteLine("This animal is a bird!");
            if (DoesItFly == true)
            {
                Console.WriteLine("This bird is able to fly!");
            }
            else
            {
                Console.WriteLine("This bird was not meant to soar");
            }
            Console.WriteLine($"This bird is from {RegionBirdIsFrom}");
            if (IsItNocturnal == true)
            {
                Console.WriteLine("This bird is awake at night, and sleeps during the day");
            }
            else
            {
                Console.WriteLine("This bird sleeps at night and is awake during the day");
            }
            Console.WriteLine($"The colors on this bird are {Colors}");
        }






    }

}
