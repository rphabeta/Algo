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
       string[] input = Console.ReadLine().Split();
        n = int.Parse(input[0]);  // 사용자가 입력하는 배열 X의 크기
        m = int.Parse(input[1]);  // 사용자가 입력하는 배열 Y의 크기

        string[] input2 = Console.ReadLine().Split();
        sy = int.Parse(input2[0]); // 출발지 y
        sx = int.Parse(input2[1]); // 출발지 x

        string[] input3 = Console.ReadLine().Split();
        ey = int.Parse(input3[0]); // 목적지 y
        ex = int.Parse(input3[1]); // 목적지 x

        for (int i = 0; i < n; i++) // 배열을 생성한다.
        {
            string[] row = Console.ReadLine().Split();
            for(int j = 0; j < m; j++)
            {
                a[i, j] = int.Parse(row[j]);
            }
        }

        Bfs(sy, sx);
    }

    static void Bfs(int sy, int sx)
    {
        visited[y, x] = 1;
        Queue<Tuple<int, int>> q = new Queue<Tuple<int, int>>();

        q.Enqueue(new Tuple<int, int>(sy, sx));
        while(q.Count() > 0)
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
                visited[ny, nx] = visited[y, x] + 1;
                q.Enqueue(new Tuple<int, int>(ny, nx));
            }
        }
        Console.WriteLine(visited[ey, ex]);
        // 최단거리 디버깅
        for (int i = 0; i < n; i++)
        {
            for(int j = 0; j < m; j++)
            {
                Console.Write(visited[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
