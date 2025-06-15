using System;

public class Solution {
    public bool solution(int x) {
        int sum = 0;
        int remain = x;
        int count = x.ToString().Length;
        
        for(int i = count -1; i >= 0; i--)
        {
            sum += remain / (int)Math.Pow(10, i);
            remain = remain % (int)Math.Pow(10, i);
        }
        
        return x % sum == 0 ? true : false;
    }
}