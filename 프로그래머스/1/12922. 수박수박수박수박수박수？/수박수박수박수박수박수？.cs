public class Solution {
    public string solution(int n) {
        string watermelon = "수박";
        string answer= "";
        
        for(int i = 0; i < n; i++)
        {
            answer += watermelon[i % 2];
        }
        
        return answer;
    }
}