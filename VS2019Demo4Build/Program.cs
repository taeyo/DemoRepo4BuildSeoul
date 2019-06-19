using System;

namespace VS2019Demo4Build
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("It's Morning!");

            var dog1 = new Dog();
            var dog2 = new Dog();
            var dog3 = new Dog();

            dog1.EatBreakfast();
            dog2.EatBreakfast();

            Console.WriteLine("It's Afternoon!");

            dog1.EatLunch();
            dog3.EatLunch();

            Console.WriteLine("It's Evening!");

            dog1.EatDinner();
            dog2.EatDinner();

        }
    }
}
