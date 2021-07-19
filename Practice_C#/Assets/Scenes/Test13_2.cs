using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test13_2 : Test13
{
    string schoolName;
    // Start is called before the first frame update
    void Start()
    {
        schoolName = "명지 초등학교";
        humanName = "명지";
        humanAge = 8;

        info();
    }

    protected override void info() // 재정의
    {
        base.info(); // 일단 기본 함수에 있는 내용들이 실행된다.
        print("나는 학생입니다.");
    }

    protected override void Name()
    {
        print(humanName);
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
