namespace Interfaces
{
    public class BettaFish : ISwimming
    {
        public int MaximumDepth { get; }

        public string Name { get; set; }

        public BettaFish(string name, int depth)
        {
            Name = name;
            MaximumDepth = depth;
        }

        public void Swim()
        {
            System.Console.WriteLine($"{Name} is swimming!");
        }
    }
}