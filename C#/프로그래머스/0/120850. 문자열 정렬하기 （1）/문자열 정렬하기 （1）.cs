using System;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(string my_string) 
    {
        List <int> answer = new List <int> ();
        
        for(int i = 0; i < my_string.Length; i++)
        {
            if(char.IsDigit(my_string[i]))
            {
                answer.Add(my_string[i] - '0');
            }
        }
        answer.Sort();
        return answer.ToArray();
    }
}