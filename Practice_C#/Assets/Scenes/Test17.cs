using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abc<T>
{
    public T var;
    public T[] array;
}

public class Test17 : MonoBehaviour
{
    /*
    void Print(int value)
    {
        print(value);
    }

    void Print(float value)
    {
        print(value);
    }

    void Print(string value)
    {
        print(value);
    }
    */

    Abc<string> a;
    Abc<float> b;

    // 어떤 Type의 쓸지 모를 class를 선언할 때, 형식 매개 변수 T를 사용항 불특정 타입의 매개변수를 받을 수 있도록 한다. 올 수 있는 Type을 명시해 줄 수도 있음.
    void Print<T>(T value) where T : class //struct의 경우는 string이 class type 이기 때문에 오류가 난다. class의 경우는 float가 오류난다.
    {
        print(value);

        a.var = "abc";

        a.array = new string[1];
        a.array[0] = "abc";

        b.var = 4.5f;

        b.array = new float[1];
        b.array[0] = 4.5f;
    }

    // Start is called before the first frame update
    void Start()
    {
        Print<string>("abc");
    }
    

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
