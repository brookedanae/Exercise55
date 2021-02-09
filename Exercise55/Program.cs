using System;

namespace Exercise55
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal type = new Animal();
            Giraffe animal1 = new Giraffe(6);
            Dog animal2 = new Dog(DogType.GermanShepherd);
            Dalmation animal3 = new Dalmation(false);

            animal1.Sound();
            animal2.Sound();
            animal3.Sound();
        }
    }
}
