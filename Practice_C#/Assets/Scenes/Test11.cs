using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 구조체에는 값을 넣어줄 수 없음 // class의 경우에는 new를 무조건 생성해줘야 한다.
public struct Youtube
{
    public int a;
    public int b;
    public int c;
    
    public Youtube(int _a, int _b, int _c)
    {
        a = _a; b = _b; c = _c;
    }

    public void GetA(int value)
    {
        a = value;
    }
}

public enum Item
{
    Weapon,
    Shield,
    Potion
}

public class Test11 : MonoBehaviour
{
    Youtube myungji = new Youtube(1, 2, 3);
    Item item;

    // Start is called before the first frame update
    void Start()
    {
        myungji.a = 5;

        myungji.GetA(5);

        print(myungji.a);

        item = Item.Weapon;
        item = Item.Shield;
        print(item);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
