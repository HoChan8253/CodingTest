using System;

public class Solution 
{
    public int[] solution(int[] array) 
    {
        int[] answer = new int[2];
        int maxValue = 0;
        int maxIndex = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if(array[i] > maxValue)
            {
                maxValue = array[i];
                maxIndex = i;
            }
        }
        answer[0] = maxValue;
        answer[1] = maxIndex;
        return answer;
    }
}