using System;
//using Linq;

public class Solution 
{
    public int[] solution(int[] num_list) 
    {
        // 풀이 1 - Array 사용
        int[] answer = new int[num_list.Length];
        int c = num_list.Length - 1;
        foreach(int rvs in num_list)
        {
            answer[c] = rvs;
            c--;
        }
        return answer;
        
        // 풀이 2 - LINQ 사용
        //return num_list.Reverse().ToArray();
    }
}