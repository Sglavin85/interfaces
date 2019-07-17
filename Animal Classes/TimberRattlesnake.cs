namespace Interfaces
{
    public class TimberRattleSnake : IWalking
    {
        public int NumberOfLegs { get; }
        public string Name { get; set; }

        public TimberRattleSnake(string name)
        {
            Name = name;
            NumberOfLegs = 0;
        }

        public void Run()
        {
            System.Console.WriteLine("slither slither slither");
        }

        public void Walk()
        {
            System.Console.WriteLine("slither slither slither");
        }
    }
}