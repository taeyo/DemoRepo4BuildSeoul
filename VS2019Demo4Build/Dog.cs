using System;
using System.Threading;
using System.IO;
using System.Web;
using System.Text;

namespace VS2019Demo4Build
{
    public class Dog : IAnimal
    {
        public void EatBreakfast()
        {
            Banana banana;
            Meat meat = new Meat();
            this.Eat(meat, (DateTime)(DateTime.Now));
        }

        public void EatLunch()
        {
            Banana banana = new Banana();
            Meat meat;
            this.Eat(banana, DateTime.Now);
        }

        public void EatDinner()
        {
            Feed feed = new Feed();

        }

        public void Bark() { }
        public void Pee() { }
        public void Poo() { }
        public void Sleep() { }

        public bool Eat(IFood food, DateTime datetime)
        {
            if (food.IsHealty && datetime >= DateTime.UtcNow)
                return true;
            else
                return false;
        }
    }
}
