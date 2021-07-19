using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ATest
{
    private int a;
    public int b;
    public static int c; // 공공의 공유자원, 정적변수, 각각 클래스마다 local 자원을 가질 수 없음, ATest 자체로 접근가능 class 자체에 접근해야 한다.

}

public class Test4 : MonoBehaviour
{
    ATest a1 = new ATest();
    ATest a2 = new ATest();
    ATest a3 = new ATest();

    void ABc()
    {
        a2.b = 5;
        a1.b = 1;
        a3.b = 10;

        ATest.c = 100;

        print(a1.b);
        print(a2.b);
        print(a3.b);
        print(ATest.c);
    }
    
    private int a; // 일반적인 선언에서 private가 쓰인다. 전역변수
    public int b;

    void Abc()
    {
        int a = 5; // 지역변수 - 생성과 파괴가 자주 일어난다. ==> 메모리 단편화와 관련이 있다.
        a = 6; // 지역 변수에 지정이 된다. 전역 변수는 무시 됌.

        int b = 5; // 지역변수
        print(b);
    }

    // Start is called before the first frame update
    void Start()
    {
        ABc();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
