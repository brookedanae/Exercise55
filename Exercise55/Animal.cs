using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise55
{
    public class Animal
    {
        public string Type { get; }

        public string Sounds { get; }

        public Animal(string type, string sounds)
        {
            Type = type;
            Sounds = sounds;
        }

        public Animal()
        {

        }

        public virtual void Sound()
        {
            Console.WriteLine($"This animal is {Type}");

        }
    }

}
