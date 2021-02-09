using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise55
{
    public class Giraffe : Animal
    {
        public int NeckLength { get; }


        public Giraffe(int neckLength) : base("Safari Animal", "Errrr")
        {
            NeckLength = neckLength;
        }

        public override void Sound()
        {
            Console.WriteLine($"This animal is a {Type}, with a large neck length of {NeckLength} feet and sounds like {Sounds}.");
        }
    }
}
