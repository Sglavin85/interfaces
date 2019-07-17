namespace Interfaces
{
    public interface IWalking
    {
        int NumberOfLegs { get; }
        void Run();
        void Walk();
    }
}