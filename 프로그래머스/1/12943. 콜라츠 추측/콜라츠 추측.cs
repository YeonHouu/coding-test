public class Solution {
    public int solution(int num) {
        
        if (num == 1) return 0;
        long answer = num;
        int count = 0;
        
        while (answer != 1)
        {
            if (count == 500) return -1;
            answer = (answer % 2 == 0) ? answer / 2 : (answer * 3) + 1;
            count++;
        }
        
       return count;
        
    }
}