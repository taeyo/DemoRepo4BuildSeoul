using System;

namespace VS2019Demo4Build
{
    public interface IAnimal
    {
        void Bark();
        bool Eat(IFood food, DateTime datetime);
        void EatBreakfast();
        void EatDinner();
        void EatLunch();
        void Pee();
        void Poo();
        void Sleep();
    }
}