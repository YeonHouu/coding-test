using System;

public class Solution {
    public int solution(int[] num_list) {
        int multiple = 1;
        int added = 0;
        
        for(int i = 0; i < num_list.Length; i++)
        {
            multiple *= num_list[i];
            added +=  num_list[i];
        }
        
        int square = added * added;
        
        return multiple < square ? 1 : 0;
    }
}