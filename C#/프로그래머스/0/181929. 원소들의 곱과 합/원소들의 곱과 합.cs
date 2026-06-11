using System;

public class Solution 
{
    public int solution(int[] num_list) 
    {
        int answer = 0;
        int sum = 0;
        int result1 = 0;
        int result2 = 1;
        foreach(int i in num_list) sum += i;
        result1 = sum * sum;
        foreach(int j in num_list) result2 *= j;
        if(result1 > result2) return 1;
        else return 0;
    }
}