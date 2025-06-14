using Xunit;
using MathLibrary;

namespace MathLibrary.Tests;

/// <summary>
/// اختبارات للدوال: Multiply, Divide, IsEven
/// </summary>
public class CalculatorTests
{
    // Multiply Tests
    [Fact]
    public void Multiply_TwoPositiveNumbers_ReturnsCorrectResult()
    {
        int a = 2, b = 3;
        int result = Calculator.Multiply(a, b);
        Assert.Equal(6, result);
    }

    [Fact]
    public void Multiply_NumberWithZero_ReturnsZero()
    {
        int a = 0, b = 5;
        int result = Calculator.Multiply(a, b);
        Assert.Equal(0, result);
    }

    [Fact]
    public void Multiply_TwoNegativeNumbers_ReturnsPositive()
    {
        int a = -2, b = -3;
        int result = Calculator.Multiply(a, b);
        Assert.Equal(6, result);
    }

    // Divide Tests
    [Fact]
    public void Divide_TwoPositiveNumbers_ReturnsCorrectResult()
    {
        int a = 10, b = 2;
        int result = Calculator.Divide(a, b);
        Assert.Equal(5, result);
    }

    [Fact]
    public void Divide_ByZero_ThrowsDivideByZeroException()
    {
        int a = 10, b = 0;
        Assert.Throws<DivideByZeroException>(() => Calculator.Divide(a, b));
    }

    [Fact]
    public void Divide_NegativeDividend_ReturnsNegativeResult()
    {
        int a = -9, b = 3;
        int result = Calculator.Divide(a, b);
        Assert.Equal(-3, result);
    }

    // IsEven Tests
    [Fact]
    public void IsEven_EvenNumber_ReturnsTrue()
    {
        int a = 4;
        bool result = Calculator.IsEven(a);
        Assert.True(result);
    }

    [Fact]
    public void IsEven_OddNumber_ReturnsFalse()
    {
        int a = 5;
        bool result = Calculator.IsEven(a);
        Assert.False(result);
    }

    [Fact]
    public void IsEven_NegativeEvenNumber_ReturnsTrue()
    {
        int a = -8;
        bool result = Calculator.IsEven(a);
        Assert.True(result);
    }
}