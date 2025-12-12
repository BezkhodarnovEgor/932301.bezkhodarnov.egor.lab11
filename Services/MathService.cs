namespace MathOperationsApp.Services;

public class MathService : IMathService
{
    private readonly Random _random = new Random();

    public int GenerateRandomNumber()
    {
        return _random.Next(0, 11);
    }

    public int Add(int a, int b) => a + b;
    public int Subtract(int a, int b) => a - b;
    public int Multiply(int a, int b) => a * b;

    public double? Divide(int a, int b)
    {
        if (b == 0)
            return null;
        return (double)a / b;
    }
}