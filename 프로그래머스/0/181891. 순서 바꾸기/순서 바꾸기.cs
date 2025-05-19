using System;

public class Solution {
    public int[] solution(int[] num_list, int n) {
        
        int[] answer = new int[num_list.Length];
        int count = 0;
       for (int i = 0; i < answer.Length; i++)
        {
           if(n + i < num_list.Length)
           {
               answer[i] = num_list[n + i];
           }
           else
           {
               answer[i] = num_list[count];
               count++;
           }
        }
        return answer;
    }
}