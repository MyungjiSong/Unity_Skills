using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Test20 : MonoBehaviour
{

    int a = 5;
    int b = 0;
    int c;

    // Start is called before the first frame update
    void Start()
    {
        try
        {
            c = a / b;
        }
        catch(DivideByZeroException ie) // catch 여러개 만들어서 오류에 따른 대처 가능
        {
            print(ie);
            b = 1;
            c = a / b;
        }
        finally // 오류가 발생하든 말든 출력
        {
            print(c);
        }

        throw new Exception("일부러 오류를 발생시킴");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
