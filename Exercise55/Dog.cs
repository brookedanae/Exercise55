using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise55
{
    public class Dog : Animal
    {
        public DogType DogBreed { get; }

        public Dog(DogType dogBreed) : base("Dog", "bark bark")
        {
            DogBreed = dogBreed;
        }

        public override void Sound()
        {
            Console.WriteLine($"This animal is a {DogBreed}, which is a {Type} and sounds like {Sounds}");

        }
    }
}
