using System;
using System.Collections.Generic;

public class Program
{
    public static List<int> DailyTemperatures(List<int> temperatures)
    {
        int tempCount = temperatures.Count;
        List<int> ans = new List<int>(new int[tempCount]);

        Stack<int> stack = new Stack<int>();
        Stack<int> idxStack = new Stack<int>();

        for (int idx = tempCount - 1; idx >= 0; idx--)
        {
            int temperature = temperatures[idx];

            int lastTempIdx = 0;
            while (stack.Count > 0)
            {
                int lastTemp = stack.Peek();
                lastTempIdx = idxStack.Peek();
                if (lastTemp <= temperature)
                {
                    stack.Pop();
                    idxStack.Pop();
                }
                else
                {
                    break;
                }
            }

            if (stack.Count == 0)
            {
                stack.Push(temperature);
                idxStack.Push(idx);
                ans[idx] = 0;
                continue;
            }

            stack.Push(temperature);
            idxStack.Push(idx);
            ans[idx] = lastTempIdx - idx;
        }

        return ans;
    }

    public static void Main()
    {
        List<int> result = DailyTemperatures(new List<int> { 39, 20, 70, 36, 30, 60, 80, 1 });
        Console.WriteLine(string.Join(", ", result));
    }
}
