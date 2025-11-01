using System;

public class Solution {
    public string solution(string s) {
        
        string[] strArr = s.Split(' ');
        
        for (int i = 0; i < strArr.Length; i++)
        {
            string str = strArr[i];
            if (string.IsNullOrEmpty(str)) continue;
            strArr[i] = char.ToUpper(str[0]) + str.Substring(1).ToLower();
        }
        
        string answer = String.Join(" ", strArr);
        return answer;
    }
}