using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test18 : MonoBehaviour
{
    int a = 5;
    int b = 5;

    int sum;

    void Add()
    {
        sum = a + b;
    }
    /*
    void Print()
    {
        print(sum);
    }
    */
    void Back()
    {
        sum = 0;
    }

    delegate void MyDelegate();
    MyDelegate myDelegate;

    // Start is called before the first frame update
    void Start()
    {
        myDelegate = Add;
        // 무명 메소드 myDelegate = Print;
        //myDelegate += delegate () { print(sum); }; // 무명 메소드
        myDelegate += () => print(sum); // 람다식
        myDelegate += Back;

        myDelegate();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
