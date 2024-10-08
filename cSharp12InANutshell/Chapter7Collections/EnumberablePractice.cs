using System.Collections;

namespace cSharp12InANutshell.Chapter7Collections;

public class EnumberablePractice
{
    public static void Run()
    {
        string s = "Hello";
        
        IEnumerator rator = s.GetEnumerator();
        while (rator.MoveNext())
        {
            char c = (char) rator.Current;
            Console.Write(c);
        }
    }
}