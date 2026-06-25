using System;

public class Solution 
{
    public int solution(string binomial) 
    {
        int answer = 0;
        string[] op = binomial.Split(' ');
        int a = int.Parse(op[0]);
        int b = int.Parse(op[2]);
        if(op[1] == "+") answer = a + b;
        else if(op[1] == "-") answer = a - b;
        else if(op[1] == "*") answer = a * b;
        else answer = a / b;
        return answer;
    }
}