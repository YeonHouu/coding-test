using System;

public class Solution {
    public int[] solution(string myString) {
        string[] myArry = myString.Split('x');
        int[] answer = new int[myArry.Length];
        for(int i =0; i < myArry.Length; i++)
        {
            answer[i] = myArry[i].Length;
        }
        return answer;
    }
}