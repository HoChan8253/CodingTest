using System;
using System.Linq;

public class Solution 
{
    public string solution(string s) 
    {
        string[] arr = s.Split(' ');
        int[] nums = Array.ConvertAll(arr, int.Parse);
        return nums.Min() + " " + nums.Max();
    }
}