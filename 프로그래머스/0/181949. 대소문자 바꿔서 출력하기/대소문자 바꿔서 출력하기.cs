using System;

public class Example
{
    public static void Main()
    {
        string str = Console.ReadLine();
        char[] changedLetter = new char[20];
        changedLetter = str.ToCharArray();
        for(int i = 0; i <changedLetter.Length; i++)
        {
            if (char.IsUpper(changedLetter[i]))
            {
                changedLetter[i]= char.ToLower(changedLetter[i]);
            }
            else
            {
                changedLetter[i] = char.ToUpper(changedLetter[i]);
            }
        }
        str = string.Join("",changedLetter);
        Console.WriteLine(str);  
    }
}