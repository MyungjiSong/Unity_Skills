using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{

    //정수 자료형
    //byte (0~255) 1바이트
    //sbyte (-128~127) 1바이트
    //short (-3만~3만) 2바이트
    //integer (-20억~20억) 4바이트
    //long (큰 범위) 8바이트

    /* 실수 자료형
     * float float = 4.0000001f;
     * double double d = 4.000000001;
     * decimal decimal m = 4.000000001m;
     */

    // 사칙연산 시, 큰 범위가 작은 범위를 먹는다. 이 때, 강제로 해결하는 방법은 (자료형)(사칙연산)식으로 저장한다.

    /* 문자 자료형
     * string s = "asdfjlie";
     * char c = 'a'; -- 0093이라하는 unicode 기억
     */

    /* u-뭐시기 - 음수가 필요없을 경우 사용함
     * ushort (0~6만)
     */

    /* boolean
     * bool a = true;
     * bool b = false;
     */

    // (int value).ToString()을 사용하여 숫자를 문자로 바꿀 수 있음
    // int.Parse(string value)를 사용하여 문자를 숫자로 바꿀 수 있음

    int a = 100;
    string  b;

    // Start is called before the first frame update
    void Start()
    {
        b = a.ToString();
        print(b);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
