using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test14 : MonoBehaviour
{
    private int salary;

    private int bonus = 10;

    public int SalaryP { get { return salary + bonus; } private set { if (value < 0) salary = 10; else salary = value; } } // 반드시 value라고 써놔야 함.

    /* 얘네를 대신할 수 있는 속성 값을 선언할 것이다.
    private void SetSalary(int value)
    {
        salary = value;
    }

    public int GetSalary()
    {
        return salary;
    }
    */

    // Start is called before the first frame update
    void Start()
    {
        SalaryP = -5;
        print(SalaryP);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
