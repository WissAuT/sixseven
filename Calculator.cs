namespace CalculatorApp;

public class Calculator
{
    // Сложение
    public int Add(int a, int b) => a + b;

    // Вычитание
    public int Subtract(int a, int b) => a - b;

    // Умножение
    public int Multiply(int a, int b) => a * b;

    // Деление
    public double Divide(int a, int b)
    {
        if (b == 0)
            throw new ArgumentException("На ноль делить нельзя!");
        return (double)a / b;
    }

    // Проверка на четность
    public bool IsEven(int a) => a % 2 == 0;

    // Максимум из двух чисел
    public int Max(int a, int b) => Math.Max(a, b);

    // Минимум из двух чисел
    public int Min(int a, int b) => Math.Min(a, b);

    // Возведение в квадрат
    public int Square(int a) => a * a;
}