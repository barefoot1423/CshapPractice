using System.Security.AccessControl;

namespace cSharp12InANutshell.Chapter6;

public class ToStringPractice
{
    public static void Run()
    {
        var failure = int.TryParse("qwerty", out int _);
        var success = int.TryParse("123", out int number);
        Console.WriteLine(failure);
        Console.WriteLine(success);
        Console.WriteLine(number);
    }
}