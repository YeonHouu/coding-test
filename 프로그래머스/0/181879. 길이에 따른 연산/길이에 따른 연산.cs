using System;

public class Solution {
    public int solution(int[] num_list) {
        
        int answer  = (num_list.Length <= 10) ? 1 : 0;
        
        for (int i = 0; i < num_list.Length; i++)
        {
           if (num_list.Length <= 10)
           {
               
                answer *= num_list[i];
           }
            else
            {
                answer += num_list[i];
            }
        }
        return answer;
    }
}