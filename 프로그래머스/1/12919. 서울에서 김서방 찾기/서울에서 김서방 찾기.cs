using System;

public class Solution {
    public string solution(string[] seoul) {
        int value = Array.IndexOf(seoul, "Kim");
        return $"김서방은 {value}에 있다";
    }
}