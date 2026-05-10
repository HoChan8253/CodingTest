using System;

public class Solution 
{
    public string solution(string my_string) 
    {
        //풀이 1 - foreach 사용
        //string answer = "";
        //foreach(char c in my_string)
        //{
        //    answer = c + answer;
        //}
        //return answer;
        
        // 풀이 2 - Array 사용
        char[] arr = my_string.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}