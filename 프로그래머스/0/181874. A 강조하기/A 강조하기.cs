using System;

public class Solution {
    public string solution(string myString) {
        string a = "a";
        myString = myString.ToLower();
        return myString.Replace(a, a.ToUpper());
    }
}