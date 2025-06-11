using System;

public class Solution {
    public int solution(int n) {
        int x = 0;
        for (int i = n; i > 0; i--)
        {
            if (n % i == 1)
            {
                 x = i;
            }
        }
        return x;
    }
}