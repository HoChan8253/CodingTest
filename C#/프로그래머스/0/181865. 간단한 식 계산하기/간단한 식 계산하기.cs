using System;

public class Solution 
{
    public int solution(string binomial) 
    {
        long answer = 0;
        string[] op = binomial.Split(' ');
        long a = int.Parse(op[0]);
        long b = int.Parse(op[2]);
        if(op[1] == "+") answer = a + b;
        else if(op[1] == "-") answer = a - b;
        else if(op[1] == "*") answer = a * b;
        else answer = a / b;
        return (int)answer;
    }
}