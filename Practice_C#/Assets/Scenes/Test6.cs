using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test6 : MonoBehaviour
{
    int input = 15;
    int num = 10;
    bool result;
    // Start is called before the first frame update
    void Start()
    {
        result = input > num;

        if (result)
        {
            print("input의 값이 num보다 큽니다");
        }

        // int temp = input == num ? 50 : 100; --> true면 50출력, false면 100출력 --> 삼항 연산자

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
