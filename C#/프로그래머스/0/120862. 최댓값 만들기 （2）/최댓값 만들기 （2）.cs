using System;

public class Solution 
{
    public int solution(int[] numbers) 
    {
        Array.Sort(numbers);

        int n = numbers.Length;

        return Math.Max(
        numbers[0] * numbers[1],
        numbers[n - 1] * numbers[n - 2]
        );
    }
}