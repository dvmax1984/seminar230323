using System;

public static class Library1
{
    public static double GetNumber(string text)
    {
        Console.Write(text);
        return Convert.ToDouble(Console.ReadLine());
    }
}