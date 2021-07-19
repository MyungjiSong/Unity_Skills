using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test7 : MonoBehaviour 
{
    int num = 0;
    string text = "가나다라마바사";
    // Start is called before the first frame update
    void Start()
    {
        // for문 (반복횟수가 명확할 때)과 while문 (반복뵛수가 명확하지 않을 때)
        foreach(char a in text)
        {
            print(a);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
