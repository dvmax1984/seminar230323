public static class Library1
{
    public static int GetNumber(string text)
    {
        Console.WriteLine(text);
        return Convert.ToInt32(Console.ReadLine());
    }
}