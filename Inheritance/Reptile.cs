using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public bool DoesItSwim { get; set; }
        public bool IsItVenomous { get; set; }
        public string LengthOfReptile { get; set; }
        public bool IsItADragon { get; set; }
        public void PrintReptile()
        {
            Console.WriteLine("Ah-Ha! This looks like a Reptile!");
            if(IsItVenomous== true)
            {
                Console.WriteLine("HOT DIGGITY DOG! THIS IS DANGEROUS");
            }else
            {
                Console.WriteLine("This is a venom free reptile!");
            }
            if (DoesItSwim== true)
            {
                Console.WriteLine("This reptile can swim! How cool!");
            }else
            {
                Console.WriteLine("This Reptile can NOT swim , keep it away from water");
            }
            Console.WriteLine($"The length of this reptile is aproximitly {LengthOfReptile}");
            if (IsItADragon== true)
            {
                Console.WriteLine("OMG THIS IS A DRAGON, HOW MUCH DO YOU WANT FOR IT?!?!");
            }else
            {
                Console.WriteLine("This would be cooler if it was a dragon");
            }
        }


    }
}
