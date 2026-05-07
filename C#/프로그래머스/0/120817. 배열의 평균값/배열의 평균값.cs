using System;

public class Solution 
{
    public double solution(int[] numbers) 
    {
        int result = 0;
        double answer = 0;
        foreach(int sum in numbers)
        {
            result += sum;
        }
        answer = result / (double)numbers.Length;
        return answer;
    }
}