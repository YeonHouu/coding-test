using System;

public class Solution {
    public int solution(int n) {
        double answer = 0;
        double remain = n;
        int count = n.ToString().Length;
        
        for (int i = count - 1; i >= 0; i--)
        {
            answer += (int)(remain / Math.Pow(10, i));
            remain = remain % Math.Pow(10, i);
        }
        return (int)answer;
    }
}