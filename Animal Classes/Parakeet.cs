namespace Interfaces
{
    public class Parakeet : IFlying, IWalking
    {
        public int WingSpan { get; }
        public string Name { get; set; }

        public int NumberOfLegs { get; }

        public Parakeet(string name, int wingSpan)
        {
            Name = name;
            WingSpan = wingSpan;
            NumberOfLegs = 2;
        }

        public void Fly()
        {
            System.Console.WriteLine($"{Name} is flying!");
        }

        public void Run()
        {
            System.Console.WriteLine($"{Name} is running!");
        }

        public void Walk()
        {
            System.Console.WriteLine($"{Name} is walking!");
        }
    }
}