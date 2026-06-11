using System;
using System.Linq;

public class Solution 
{
    public int solution(int[] num_list) 
    {
        // 풀이 1
        //int answer = 0;
        //int sum = 0;
        //int result1 = 0;
        //int result2 = 1;
        //foreach(int i in num_list) sum += i;
        //result1 = sum * sum;
        //foreach(int j in num_list) result2 *= j;
        //if(result1 > result2) return 1;
        //else return 0;
        
        // 풀이 2
        int sum = num_list.Sum();
        int product = num_list.Aggregate((acc, x) => acc * x);
        return product < sum * sum ? 1 : 0;
    }
}