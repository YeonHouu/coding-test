using System;

public class Example
{
    public static void Main()
    {
        char[] answer = Console.ReadLine().ToCharArray();
        foreach (char characters in answer)
        {
            Console.WriteLine(characters);
        }
    }
}