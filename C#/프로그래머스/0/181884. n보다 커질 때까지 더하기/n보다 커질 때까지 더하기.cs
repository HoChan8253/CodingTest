using System;

public class Solution 
{
    public int solution(int[] numbers, int n) 
    {
        int answer = 0;
        int result = 0;
        for(int i = 0; i < numbers.Length; i++)
        {
            result += numbers[i];
            if(result > n)
            {
                answer = result;
                break;
            }
        }
        return answer;
    }
}