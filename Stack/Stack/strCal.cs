using System;
using System.Collections.Generic;

public class Calculator
{
    public static int Calculate(string s)
    {
        s += "+"; // additional last op
        List<int> stack = new List<int>();

        int curNum = 0;
        char prevOp = '+';
        foreach (char c in s)
        {
            if (char.IsDigit(c))
            {
                curNum = curNum * 10 + int.Parse(c.ToString());
            }
            else if (c == ' ')
            {
                continue;
            }
            else // ops
            {
                if (prevOp == '+')
                {
                    stack.Add(curNum);
                }
                else if (prevOp == '-')
                {
                    stack.Add(-curNum);
                }
                else if (prevOp == '*')
                {
                    stack[stack.Count - 1] *= curNum;
                }
                else if (prevOp == '/')
                {
                    stack[stack.Count - 1] = (int)(stack[stack.Count - 1] / curNum);
                }

                curNum = 0;
                prevOp = c;
            }
        }

        int result = 0;
        foreach (int num in stack)
        {
            result += num;
        }

        return result;
    }

    public static void Main(string[] args)
    {
        int result = Calculate("7 - 6 / 3 + 3 * 2 + 4");
        Console.WriteLine(result);
    }
}
