namespace MathLibrary;

/// <summary>
/// يحتوي على دوال رياضية بسيطة
/// </summary>
public static class Calculator
{
    /// <summary>
    /// تحسب حاصل ضرب عددين صحيحين
    /// </summary>
    public static int Multiply(int a, int b)
    {
        return a * b;
    }

    /// <summary>
    /// تحسب قسمة عددين صحيحين
    /// </summary>
    public static int Divide(int a, int b)
    {
        if (b == 0)
            throw new DivideByZeroException("Cannot divide by zero.");
        return a / b;
    }

    /// <summary>
    /// تتحقق مما إذا كان العدد زوجيًا
    /// </summary>
    public static bool IsEven(int a)
    {
        return a % 2 == 0;
    }
}