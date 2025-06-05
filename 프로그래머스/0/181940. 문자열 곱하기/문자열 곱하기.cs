using System;

public class Solution {
    public string solution(string my_string, int k) {
        
        string[] array = new string[k];
        
        for(int i = 0; i < k; i++)
        {
            array[i] = my_string;
        }

        return string.Join("", array);
    }
}