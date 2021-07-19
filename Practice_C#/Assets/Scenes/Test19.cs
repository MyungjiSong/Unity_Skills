using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; // 추가함

public class Test19 : MonoBehaviour
{

    delegate void MyDelegate<T1, T2>(T1 a, T2 b); // 반환값이 없는 겨우는 action 있는 경우는 function 사용
    MyDelegate<int, int> myDelegate;

    Action<int, int> myDelegate2; // System에 똑같은 내용이 만들어져 있음

    delegate string MyDelegate3<T1, T2>(T1 a, T2 b); // 반환값이 없는 겨우는 action 있는 경우는 function 사용
    MyDelegate<int, int> myDelegate3;

    Func<int, int, string> myDelegate4;

    // Start is called before the first frame update
    void Start()
    {
        myDelegate4 = (int a, int b) => { int sum = a + b; return sum + "이 리턴 되었습니다."; };

        print(myDelegate4(3, 5));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
