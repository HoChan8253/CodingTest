using System;

public class Solution 
{
    public int solution(int[] arr1, int[] arr2) 
    {
        if (arr1.Length != arr2.Length)
        return arr1.Length.CompareTo(arr2.Length);
    
        int sum1 = 0, sum2 = 0;
        for (int i = 0; i < arr1.Length; i++)
        {
            sum1 += arr1[i];
            sum2 += arr2[i];
        }
        return sum1.CompareTo(sum2);
    }
}