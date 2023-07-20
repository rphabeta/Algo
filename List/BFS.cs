public class ShortestPath
{
    const int MAX_N = 104;
    static int[] dy = { -1, 0, 1, 0 };
    static int[] dx = { 0, 1, 0, -1 };
    static int n, m;
    static int[,] a = new int[MAX_N, MAX_N];
    static int[,] visited = new int[MAX_N, MAX_N];
    static int y, x, sy, sx, ey, ex;

    public static void Main(string[] args)
    {
        string[] input1 = Console.ReadLine().Split(' ');
        y = int.Parse(input1[0]);
        x = int.Parse(input1[1]);

        string[] input2 = Console.ReadLine().Split(' ');
        sy = int.Parse(input2[0]); // start y
        sx = int.Parse(input2[1]); // start x

        string[] input3 = Console.ReadLine().Split(' ');
        ey = int.Parse(input3[0]);
        ex = int.Parse(input3[1]);

        for (int i = 0; i < n; i++)
        {
            string[] row = Console.ReadLine().Split();
            for (int j = 0; j < m; j++)
            {
                a[i, j] = int.Parse(row[j]);
            }
        }
        Queue<Tuple<int, int>> q = new Queue<Tuple<int, int>>();
        visited[sy, sx] = 1;
        q.Enqueue(new Tuple<int, int>(sy, sx));
        while(q.Count > 0)
        {
            Tuple<int, int> pair = q.Dequeue();
            y = pair.Item1;
            x = pair.Item2;

            for(int i = 0; i < 4; i++)
            {
                int ny = y + dy[i];
                int nx = x + dx[i];
                if (ny < 0 || ny >= n || nx < 0 || nx >= m || a[ny, nx] == 0) continue;
                if (visited[ny, nx] != 0) continue;
                visited[ny, nx] = visited[x, y] + 1;
                q.Enqueue(new Tuple<int, int>(ny, nx));
            }
        }
        Console.WriteLine(visited[ey, ex]);
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < m; j++)
            {
                Console.Write(visited[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}




