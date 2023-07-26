/*
   민수는 2400이란 숫자를 좋아한다. 태민이는 민수의 수를 만들고자 하는데 민수의 수란 2400이 들어간 수를 말한다.
   첫 번째 민수의 수는 2400이고 두 번째 민수의 수는 12400, 세번째 민수의 수는 224000이다.
   N이 입력을 주어졌을 때 N번째 민수의 수를 구하라. N은 300이하로 주어진다.
*/
#include <bits/stdc++.h>
using namespace std;
int n, cnt;
const int INF = 1e6;
int main(){
    cin >> n;
    int i = 2400;
    while(true){
        string a = to_string(i);
        if(a.find("2400") != string::npos) {
            cnt++;
            if(n == cnt){
                cout << a << '\n';
                break;
            }
        }
    }
    return 0;
}
