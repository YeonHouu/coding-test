using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr) {
        int minValue = arr.Min();
        
        if (arr.Length == 1)
        {
            return new int[] { -1 };
        }
        else
        {
            return arr.Where(x => x != minValue).ToArray();
        }
    }
}