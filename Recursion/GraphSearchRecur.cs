using System;

public class GraphTraversal
{
    const int V = 10;
    static bool[,] a = new bool[V, V];
    static bool[] Visited = new bool[V];

    static void Go(int from)
    {
        Visited[from] = true;
        Console.WriteLine(from);

        for (int i = 0; i < V; i++)
        {
            if (Visited[i]) continue;
            if (a[from, i])
            {
                Go(i);
            }
        }
    }

    public static void Main()
    {
        a[1, 2] = true; a[1, 3] = true; a[3, 4] = true;
        a[2, 1] = true; a[3, 1] = true; a[4, 3] = true;

        for (int i = 0; i < V; i++)
        {
            for (int j = 0; j < V; j++)
            {
                if (a[i, j] && !Visited[i])
                {
                    Go(i);
                }
            }
        }
    }
}
