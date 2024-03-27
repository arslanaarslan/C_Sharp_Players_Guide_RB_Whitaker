using System.Runtime.CompilerServices;

namespace Better_Random;

public static class RandomExtensions
{
    public static double NextDouble(this int number)
    {
        return new Random().NextDouble() * number;
    }

    public static string NextString(params string[] strings)
    {
        return new Random().GetItems<string>(strings, strings.Length)[0];
    }

    public static bool CoinFlip(this int frequency)
    {
        return NextDouble(100) < frequency;
    }
}