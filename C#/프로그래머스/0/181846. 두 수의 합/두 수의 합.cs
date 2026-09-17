using System.Numerics;

public class Solution 
{
    public string solution(string a, string b) 
    {
        return (BigInteger.Parse(a) + BigInteger.Parse(b)).ToString();
    }
}