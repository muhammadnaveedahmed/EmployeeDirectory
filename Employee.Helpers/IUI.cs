namespace Employee.Helpers
{
    public interface IUI
    {
        string? GetInput();
        void Print(string message);
    }
}