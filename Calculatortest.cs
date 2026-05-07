using Xunit;

namespace CalculatorApp.Tests;

public class CalculatorTests
{
    private readonly Calculator _calculator;

    public CalculatorTests()
    {
        _calculator = new Calculator();
    }

    [Fact]
    [Trait("Category", "Arithmetic")]
    public void Add_ShouldReturnSum()
    {
        // Arrange & Act & Assert
        Assert.Equal(5, _calculator.Add(2, 3));
        Assert.Equal(-1, _calculator.Add(-2, 1));
        Assert.Equal(0, _calculator.Add(0, 0));
    }

    [Fact]
    [Trait("Category", "Arithmetic")]
    public void Subtract_ShouldReturnDifference()
    {
        Assert.Equal(2, _calculator.Subtract(5, 3));
        Assert.Equal(-5, _calculator.Subtract(0, 5));
        Assert.Equal(10, _calculator.Subtract(5, -5));
    }

    [Fact]
    public void Multiply_ShouldReturnProduct()
    {
        Assert.Equal(15, _calculator.Multiply(3, 5));
        Assert.Equal(0, _calculator.Multiply(0, 10));
        Assert.Equal(-12, _calculator.Multiply(-3, 4));
    }

    [Fact]
    public void Divide_ShouldReturnQuotient()
    {
        Assert.Equal(2.5, _calculator.Divide(5, 2));
        Assert.Equal(0.0, _calculator.Divide(0, 5));
        Assert.Equal(-2.0, _calculator.Divide(6, -3));
    }

    [Fact]
    public void Divide_ByZero_ShouldThrowException()
    {
        var exception = Assert.Throws<ArgumentException>(() => _calculator.Divide(10, 0));
        Assert.Equal("На ноль делить нельзя!", exception.Message);
    }

    [Theory]
    [InlineData(4, true)]
    [InlineData(0, true)]
    [InlineData(7, false)]
    [InlineData(-3, false)]
    public void IsEven_ShouldReturnCorrectResult(int input, bool expected)
    {
        Assert.Equal(expected, _calculator.IsEven(input));
    }

    [Theory]
    [InlineData(10, 5, 10)]
    [InlineData(3, 8, 8)]
    [InlineData(-5, -1, -1)]
    [InlineData(7, 7, 7)]
    public void Max_ShouldReturnMaximum(int a, int b, int expected)
    {
        Assert.Equal(expected, _calculator.Max(a, b));
    }

    [Theory]
    [InlineData(10, 5, 5)]
    [InlineData(3, 8, 3)]
    [InlineData(-5, -1, -5)]
    public void Min_ShouldReturnMinimum(int a, int b, int expected)
    {
        Assert.Equal(expected, _calculator.Min(a, b));
    }

    [Theory]
    [InlineData(4, 16)]
    [InlineData(0, 0)]
    [InlineData(-3, 9)]
    public void Square_ShouldReturnSquare(int input, int expected)
    {
        Assert.Equal(expected, _calculator.Square(input));
    }
}