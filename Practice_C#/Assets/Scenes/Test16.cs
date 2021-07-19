using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class A : MonoBehaviour
{
    public int a;
    abstract public void Abc();
}
interface ITest
{
    // 뼈대 제공 다중 상속
    void Bbc();

    // 함수, 프로퍼티, 인덱서, 이벤트 만 사용 가능

    int SalaryP { get; set; }
}

interface ITest2 : ITest
{

}

public class Test16 : A, ITest // class는 하나만 상속 받을 수 있음 --> 인터페이스 사용
{
    public int SalaryP
    {
        get
        {
            return 0;
        }
        set
        {

        }
    }
    public override void Abc()
    {
        a = 5;
    }

    // 인터페이스는 재정의 할 때 override 안쓴다.
    public void Bbc()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
