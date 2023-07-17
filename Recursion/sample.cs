namespace practice_reg
{
    class program
    {
        public static void main(string[] args)
        {
            int[] a = new int[100004];
            int[] psum = new int[100004];
            int b, c, n, m;

            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                psum[i] = psum[i - 1] + a[i];
            }

            for(int i = 0; i < m; i++)
            {
                b = int.Parse(Console.ReadLine());
                c = int.Parse(Console.ReadLine());

                Console.WriteLine(psum[c] - psum[b - 1]);
            }

            
        }
    }

    class Reg2
    {
        List<int> list = new List<int>();
        void swap(List<int> list, int a, int b)
        {
            int tmp = list[a];
            list[a] = list[b];
            list[b] = tmp;
        }
        void MakePermutation(int n, int r, int depth) 
        {
            if (r == depth) // 기본적인 마인드는 while 루프에서 가지고 있는 탈출 조건을 생각하기는 하지만, 여기 내부에 있는 for문과 같이 내부 스코프까지 적용되는 하나의 독특한 양식으로 받아들이면 좋지 않을까?
            {
                //logic
                return;
            }
            for(int i = depth; i < n; i++) // 우선 처음에는 이게 어떻게 진행하는지 도식도를 그리면서 진행되는 모습이 대충 머리속으로 그려져야하고, 거기서 추가로 이게 어떤식으로 식이 꾸며졌는지 생각해볼 필요가 있겠지.
            {                              // 바깥에 while루프가 있고, 지금 여기는 내부 다중으로 선언된 for문이라고 생각하면 조금 접근하기 편하다. 즉, depth는 바깥루프에서 한 사이클 돌떄마다 변하는  기준 값이라고 생각하면 된다.
                swap(list, i, depth);      // 그래서 그 바깥 사이클의 기준과 현재 돌고 있는 for문의 변하는 값을 기준으로 swap하는거지.
                MakePermutation(n, r, depth + 1); // 그리고 여기가 조금 독특한 부분인데 재귀의 핵심이되는 부분으로 트리의 첫 부분을 쭉 내려간다고 생각하면 편하지 않을까?
                swap(list, i, depth);
            }
        }
        
        int go(int left, int right)
        {
            if (left == right) return list[left];               // 이건 while루프의 탈출조건으로 이홰하면 편해.(모든 부분에서 적용되는 특이한 조건이라고 생각하면 좋지 않을까?)
            int mid = (left + right) / 2;                       // 그리고 이건 피봇을 구하는 과정이라고 생각하면 편하다. 보통 컨테이너를 다루는 과정에서 대부분은 인덱스를 순차적으로 탐색하는 것 아니면, 이와 같이 피봇을 구하고 그 피봇을 기준으로 파티션을 하던지 아니면 비교의 기준점으로 만드는 등의 활동을 하는 것을 많이 하지.
            int sum = go(left, mid) + go(mid + 1, right);       // 그리고 이건 그 앞선 피봇을 기준으로 이제 파티션을 하는 과정이라고 생각하면 된다. 파티션의 경우는 저렇게 애초에 재귀로 익혀둬서, 크게 어색하거나 그렇지는 않은 것 같은데.
            return sum;
        }

        // Problem을 subProblem으로 나누어서 어떤식으로 할건지를 생각학라고 하지. 맞아 먼저 subProblemd으로 나누는 것을 생각하고 그에 맞춰서 어떤 과정이 필요할지 생각하고 거기서 필요하다면 pivot을 반복적으로 구하거나,
        // 아니면 Index를 반복적으로 작게 나눠서 문제를 해결해 나가는 방식이지.

        int k, n;
        void combi(int start, List<int> list)
        {
            if (list.Count() == k) // 3개를 다 채우는 조건에서 멈춘다. 뎁스를 추가해도 되겠지만, 지금 list로 충분히 뎁스를 구할 수 있고 그 뎁스가 의미하는 바가 저 몇개를 채워 넣었는지 횟수를 원하는것이니. 
            {
                //logic
                return;
            }
            for(int i = start + 1; i < n; i++)
            {
                list.Add(i);       // 여기서는 바깥 루프에서 기준이되는 값이 start라는 값이 된다고 보면 되고,
                combi(i, list);    // 그리고 여기서는 while 조건에서 기준변수를 변하게 바꿔주는 과정을 추가하는  단계로 이해해도 나쁘지 않을 것 같다.
                list.RemoveAt(list.Count() - 1);
            }
        }
    }
}
