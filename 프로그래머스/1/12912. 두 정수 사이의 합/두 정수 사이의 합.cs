using System;

public class Solution {
    public long solution(int a, int b) {
        int n = Math.Abs(a-b) + 1;
        
        return (long)(a+b) * n / 2;
    }
}