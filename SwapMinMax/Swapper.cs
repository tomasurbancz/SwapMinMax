namespace SwapMinMax;

public class Swapper
{
    public static int[] SwapInt(int num1, int num2)
    {
        (num1, num2) = (num2, num1);
        return new int[] { num1, num2 };
    }

    public static string[] SwapString(string str1, string str2)
    {
        (str1, str2) = (str2, str1);
        return new string[] { str1, str2 };
    }

    public static decimal[] SwapDecimal(decimal num1, decimal num2)
    {
        (num1, num2) = (num2, num1);
        return new decimal[] { num1, num2 };
    }

    public static int MaxInt(int num1, int num2)
    {
        return Math.Max(num1, num2);
    }

    public static decimal MaxDecimal(decimal num1, decimal num2)
    {
        return Math.Max(num1, num2);
    }

    public static int MinInt(int num1, int num2)
    {
        return Math.Max(num1, num2);
    }

    public static double MinDouble(double num1, double num2)
    {
        return Math.Max(num1, num2);
    }
}