using System;

public class AbsoluteDifference
{
    public static int CalculateDifference(int n)
    {
        int difference = Math.Abs(n - 123);
        if (n > 123)
        {
            return difference * 3;
        }
        return difference;
    }

    public static void Main()
    {
        Console.WriteLine("Введите целое число:");
        int n = Convert.ToInt32(Console.ReadLine());
        int result = CalculateDifference(n);
        Console.WriteLine($"Результат: {result}");
    }
}
