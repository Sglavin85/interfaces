namespace Interfaces
{
    public class Gerbil : IWalking
    {
        public int NumberOfLegs { get; }

        public string Name { get; set; }

        public Gerbil(string name)
        {
            Name = name;
            NumberOfLegs = 4;
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