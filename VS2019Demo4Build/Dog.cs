using System;
using System.Threading;
using System.IO;

namespace VS2019Demo4Build
{
    public class Dog : IAnimal
    {
        public void EatBreakfast()
        {
            Meat meat = new Meat();
            Eat(meat, DateTime.Now);
        }

        public void EatLunch()
        {
            Banana banana = new Banana();
            Eat(banana, DateTime.Now);
        }

        public void EatDinner()
        {
            Feed feed = new Feed();
            Eat(feed, DateTime.Now);
        }

        public void Bark() { }
        public void Pee() { }
        public void Poo() { }
        public void Sleep() { }

        private bool Eat(IFood food, DateTime datetime)
        {
            if (food.IsHealty && datetime >= DateTime.UtcNow)
                return true;
            else
                return false;
        }
    }       
}
