using System;

public class Solution {
    public int solution(string myString, string pat) {
       bool answer;
myString = myString.ToLower();
pat = pat.ToLower();
answer = (myString.Contains(pat)) ? true : false;
return Convert.ToInt32(answer);
    }
}