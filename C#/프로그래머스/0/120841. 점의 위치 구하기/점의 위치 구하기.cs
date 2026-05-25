using System;

public class Solution 
{
    public int solution(int[] dot) 
    {
        int answer = 0;
        int x = dot[0];
        int y = dot[1];
        if(0 < x && 0 < y) answer = 1;
        if(0 > x && 0 < y) answer = 2;
        if(0 > x && 0 > y) answer = 3;
        if(0 < x && 0 > y) answer = 4;
        return answer;
    }
}