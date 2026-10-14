using System;
using System.Linq;

public class Solution
{
    public string[] solution(string[] str_list)
    {
        int index = Array.FindIndex(str_list,
            s => s == "l" || s == "r");

        if (index == -1) return new string[0];

        if (str_list[index] == "l") return str_list.Take(index).ToArray();

        return str_list.Skip(index + 1).ToArray();
    }
}