using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise55
{
    class Dalmation : Dog
    {
        public bool HasSpots { get; }

        public Dalmation(bool hasSpots = true) : base (DogType.Dalmation)
        {
            HasSpots = hasSpots;
        }

        public override void Sound()
        {
            Console.WriteLine($"This animal is a {DogBreed}, which is a {Type}, and {(HasSpots ? "has spots" : "does not have spots")}. It sounds like {Sounds}");
        }
    }
}
