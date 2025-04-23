using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
   public string[] solution(string my_string)
{
    string[] splited = my_string.Split(' ');
    List<string> splitedList = new List<string>();
    splitedList = splited.ToList();
    for (int i = splitedList.Count-1; i >= 0; i--)
    {
        if (splitedList[i] == (""))
        {
            splitedList.RemoveAt(i);
        }
    }
    splited = splitedList.ToArray();
    return splited;
}
}