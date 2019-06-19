namespace VS2019Demo4Build
{
    public interface IFood
    {
        bool IsHealty { get; }
    }

    public class Banana : IFood
    {
        public bool IsHealty => true;
    }

    public class Meat : IFood
    {
        public bool IsHealty => true;
    }

    public class Feed : IFood
    {
        public bool IsHealty => true;
    }
}