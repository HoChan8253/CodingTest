using System;
using System.Linq;

public class Solution 
{
    public string solution(string my_string, string letter) 
    {
        // 풀이 1 - foreach 사용
        //string answer = "";
        //foreach(char c in my_string)
        //{
        //    if(c.ToString() == letter)
        //    {
        //        continue;
        //    }
        //    answer += c;
        //}
        //return answer;
        
        // 풀이 2 - LINQ 사용
        return my_string.Replace(letter, "");
    }
}