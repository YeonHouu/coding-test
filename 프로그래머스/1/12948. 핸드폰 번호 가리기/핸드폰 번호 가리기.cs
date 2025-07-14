public class Solution {
    public string solution(string phone_number) {
        
        char[] changed = new char[phone_number.Length];
        
        for (int i = 0; i < changed.Length - 4; i++)
        {
            changed[i] = '*';
        }
        
        for (int i = changed.Length - 4; i < changed.Length; i++)
        {
            changed[i] = phone_number[i];
        }
     
        string result = string.Concat(changed);

        return result;
    }
}