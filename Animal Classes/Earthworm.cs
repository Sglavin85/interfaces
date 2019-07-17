namespace Interfaces
{
    public class Earthworm : IDigging
    {
        public int MaxDepth { get; }

        public string Name { get; set; }

        public Earthworm(string name, int depth)
        {
            Name = name;
            MaxDepth = depth;
        }

        public void Dig()
        {
            System.Console.WriteLine($"{Name} is Digging to {MaxDepth} meters!");
        }
    }
}