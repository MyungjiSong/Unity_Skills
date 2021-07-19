using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test5 : MonoBehaviour
{
    // 기본 연산자 +, -, *, /. 5. = (대입연산자)
    // ++, -- 증감 연산자 전위[선 연산 코드 실행]. 후위[선 코드 실행 후 연산]
    // 관계 연산자 ==, >=, <=, >, < !=
    // 논리 연산자 &&, ||, !
    // 비트 연산자 &(AND) |(OR) ^(XOR) ~(NOT)
    // 00001010
    // 00001100 &
    // 00001000
    // << >>

    int a = 10;
    int b = 10;
    bool c = false;
    // Start is called before the first frame update
    void Start()
    {
        // a %= b;  복합 대입 연산자
        c = (a == b); // 관계 연산자 ==, 논리 연산자 ||, &&, NOT !
        print(c);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
