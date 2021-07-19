using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Test13 : MonoBehaviour
{
    protected string humanName; // public 은 타 클래스에서 모두 사용 가능, protected 는 상속 받은 자식 클래스만 사용 가능
    protected int humanAge;

    protected virtual void info() // 가상 함수로 만들겠다는 뜻
    {
        print("나는 인간입니다.");
    }

    abstract protected void Name(); // 미완성 함수이고 자식 클래스에서 무조건 완성시켜 주어야 함.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
