namespace cSharp12InANutshell.Chapter6;

public class Chapter6
{
    public static void Run()
    {
        DateTime dt1 = new DateTime(2000,1,1, 10, 20, 30, DateTimeKind.Local);
        DateTime dt2 = new DateTime(2000,1,1, 10, 20, 30, DateTimeKind.Utc);

        Console.WriteLine(dt1 == dt2);
        DateTime local = DateTime.Now;
        DateTime utc = local.ToUniversalTime();
        Console.WriteLine(utc);
        Console.WriteLine(local);
        Console.WriteLine(local == utc);
    }
}
