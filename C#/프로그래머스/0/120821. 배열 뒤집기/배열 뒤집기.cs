using System;

public class Solution 
{
    public int[] solution(int[] num_list) 
    {
        int[] answer = new int[num_list.Length];
        int c = num_list.Length - 1;
        foreach(int rvs in num_list)
        {
            answer[c] = rvs;
            c--;
        }
        return answer;
    }
}