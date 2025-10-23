public class Solution {
    public string solution(string s) 
    {
        char[] answer = s.ToCharArray();
        
        for (int i = 0; i < answer.Length - 1; i++)
        {
            for (int j = 0; j < answer.Length - i - 1; j++)
            {
                    if (answer[j] < answer[j + 1])
                    {
                        char temp = answer[j];
                        answer[j] = answer[j + 1];
                        answer[j + 1] = temp;
                    }
               }
         }
        string result = new string(answer);
        
        return result;
    }
}