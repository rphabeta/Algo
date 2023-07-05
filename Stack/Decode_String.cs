using System;
using System.Collections.Generic;

public class Program
{
    public static string DecodeString(string s)
    {
        Stack<string> stack = new Stack<string>();
        Stack<int> numStack = new Stack<int>();

        int curNum = 0;
        string curStr = "";

        foreach (char c in s)
        {
            if (c == '[')
            {
                stack.Push(curStr);
                numStack.Push(curNum);
                curStr = "";
                curNum = 0;
                continue;
            }
            else if (c == ']')
            {
                string prevStr = stack.Pop();
                int num = numStack.Pop();
                curStr = prevStr + new string(curStr.ToCharArray(), 0, curStr.Length) + new string(curStr.ToCharArray(), 0, curStr.Length);
                continue;
            }

            if (char.IsDigit(c))
            {
                curNum = curNum * 10 + int.Parse(c.ToString());
            }
            else
            {
                curStr += c;
            }
        }

        return curStr;
    }

    public static void Main(string[] args)
    {
        string result = DecodeString("a2[b2[ak]]");
        Console.WriteLine(result);
    }
}
