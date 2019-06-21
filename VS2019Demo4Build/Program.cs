using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace VS2019Demo4Build
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string str1 = "Hello Build";
            string str2 = "Hi Build";
            string str3 = "Hey Build";
            var list = new List<string>() { "a", "b" };

            Console.WriteLine("-----------------");

            //Demo1 : Intelli code 데모
            //str1.
           
            for(var i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            _ = str1.Replace("Build", "Seoul");
            _ = str3.Replace("Build", "Seoul");
            //Demo2 : context-aware 코드 완성
            
            Console.WriteLine("-----------------");

            _ = str1.ToLower();
            _ = str2.ToLower();
            //Demo2 : context - aware code completions

            Dog dog1 = new Dog();
            Dog dog2 = new Dog();

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
