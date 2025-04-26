using System;

public class Solution {
    public string solution(string my_string, string overwrite_string, int s) {
        
        string removed = my_string.Remove(s, overwrite_string.Length);
        string answer = removed.Insert(s, overwrite_string);
        return answer;
    }
}