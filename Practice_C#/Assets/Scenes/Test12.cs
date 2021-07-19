using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test12 : MonoBehaviour
{

    public delegate void ChainFunction(int value); // 함수를 빼고 지울 수 있느 함수
    public static event ChainFunction OnStart;

    int power;
    int defence;

    public void SetPower(int value)
    {
        power += value;
        print("power의 값이" + value + "만큼 증가했습니다. 총 power 값 = " + power);
    }

    public void SetDefence(int value)
    {
        defence += value;
        print("defence의 값이" + value + "만큼 증가했습니다. 총 defence 값 = " + defence);
    }
    // Start is called before the first frame update
    void Start()
    {
        // chain이라는 함수에 SetPower와 SetDefence 함수가 추가된 것이다.
        //chain += SetPower;
        //chain += SetDefence;

        //chain(5);
        //chain(5);

        OnStart += SetPower;
        OnStart += SetDefence;
    }

    private void OnDisable()
    {
        OnStart(5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
