using System;

public class Solution 
{
    public int solution(int[] num_list, int n) 
    {
        int answer = 0;
        if(num_list.Contains(n)) answer = 1;
        return answer;
    }
}