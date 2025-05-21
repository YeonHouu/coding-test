using System;

public class Solution {
    public string solution(string myString) {
        
        char[] charArr = myString.ToCharArray();
        for (int i = 0; i < charArr.Length; i++)
        {
            if (charArr[i] < 'l')
            {
                charArr[i] = 'l';
            }
        }
        return myString = string.Concat(charArr);
    }
}