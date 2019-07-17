namespace Interfaces
{
    public class Terrapin : ISwimming, IWalking
    {
        public string Name { get; set; }

        public int MaximumDepth { get; }

        public int NumberOfLegs { get; }

        public Terrapin(string name, int maxDepth)
        {
            Name = name;
            MaximumDepth = maxDepth;
            NumberOfLegs = 4;
        }
        public void Run()
        {
            System.Console.WriteLine($"{Name} can't run! It's a turtle!");
        }

        public void Swim()
        {
            System.Console.WriteLine($"{Name} is swimming!");
        }

        public void Walk()
        {
            System.Console.WriteLine($"{Name} is Walking");
        }
    }
}