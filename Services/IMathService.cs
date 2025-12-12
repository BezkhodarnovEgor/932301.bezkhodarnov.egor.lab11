namespace MathOperationsApp.Services;

public interface IMathService
{
    int GenerateRandomNumber();
    int Add(int a, int b);
    int Subtract(int a, int b);
    int Multiply(int a, int b);
    double? Divide(int a, int b);
}