using System;

public class Solution 
{
    public string solution(string myString) 
    {
        // 풀이 1
        //string answer = "";
        //foreach(char c in myString)
        //{
        //    char lower = char.ToLower(c);
        //    if(lower == 'a') answer += 'A';
        //    else answer += lower;
        //}
        //return answer;
        
        // 풀이 2
        return myString.ToLower().Replace("a", "A");
    }
}