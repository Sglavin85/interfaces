namespace Interfaces
{
    public class Ants : IWalking, IDigging
    {
        public int NumberOfLegs { get; }

        public int MaxDepth { get; }

        public string Name { get; set; }
        public int Population { get; set; }

        public Ants(string name, int pop, int depth)
        {
            Name = name;
            Population = pop;
            MaxDepth = depth;
            NumberOfLegs = 6;
        }
        public void Dig()
        {
            System.Console.WriteLine($"{Name} are digging to {MaxDepth}");
        }

        public void Run()
        {
            System.Console.WriteLine($"{Name} are scattering!");
        }

        public void Walk()
        {
            System.Console.WriteLine($"{Name} are working!");
        }
    }
}