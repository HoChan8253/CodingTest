using System;

public class Solution 
{
    public int solution(int[] numbers) 
    {
        int first = int.MinValue;
        int second = int.MinValue;
        
        for(int i = 0; i < numbers.Length; i++)
        {
            if(numbers[i] > first)
            {
                second = first;
                first = numbers[i];
            }
            else if(numbers[i] > second)
            {
                second = numbers[i];
            }
        }
        return first * second;
    }
}