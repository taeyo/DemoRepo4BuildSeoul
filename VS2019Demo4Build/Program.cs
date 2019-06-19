using System;

namespace VS2019Demo4Build
{
    class Program
    {
        static void Main(string[] args)
        {
            string ex1 = "Hello Build";
            string ex2 = "Hi Build";
            string ex3 = "Hey Build";

            Console.WriteLine("-----------------");

            //Demo1 : Intelli code 데모
            //ex1.

            var repla = ex1.Replace("Build", "Seoul");
            repla = ex3.Replace("Build", "Seoul");
            //Demo2 : context-aware 코드 완성

            Console.WriteLine("-----------------");

            var lower = ex1.ToLower();
            lower = ex2.ToLower();
            //Demo2 : context - aware code completions



            var dog1 = new Dog();
            var dog2 = new Dog();

            dog1.EatBreakfast();
            dog2.EatBreakfast();

            //Console.WriteLine("It's Afternoon!");

            //dog1.EatLunch();
            //dog3.EatLunch();

            //Console.WriteLine("It's Evening!");

            //dog1.EatDinner();
            //dog2.EatDinner();
        }

        //void Method1()
        //{
        //    Console.WriteLine(GetMyString("Build"));
        //}

        //void Method2()
        //{
        //    Console.WriteLine(GetMyString("Build"));
        //}

        //void Method3()
        //{
        //    Console.WriteLine(string.Format("Hello {0}", "Build"));
        //}
        //static private string GetMyString(string s)
        //{
        //    return "Hello " + s;
        //}
    }
}
