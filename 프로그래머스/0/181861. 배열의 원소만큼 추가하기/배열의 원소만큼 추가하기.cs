using System;

public class Solution {
    public int[] solution(int[] arr) {
        
        int answerLength = 0;
        int count = 0;
        
         for (int i = 0; i < arr.Length; i++)
         {
              answerLength += arr[i];
         }
        
        int[] answer = new int[answerLength];
        
        for (int i = 0; i < arr.Length; i++ )
        {
            for(int j = 0; j < arr[i];  j++ )
            {
                answer[count] = arr[i];
                count++;
            }
        }
        return answer;
    }
}