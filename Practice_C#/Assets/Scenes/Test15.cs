using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Record
{
    public int[] temp = new int[5];

    public int this[int index]
    {
        get {
            if (index >= temp.Length)
            {
                Debug.Log("인덱스가 너무 큽니다.");
                return 0;
            }
            else
                return temp[index]; }
        set { if (index >= temp.Length) Debug.Log("인덱스가 너무 큽니다."); else temp[index] = value; }
    }
}

public class Test15 : MonoBehaviour
{
    Record record = new Record();

    // Start is called before the first frame update
    void Start()
    {
        record.temp[3] = 5; // 좀 길어서 인덱서를 활용해서 줄이자
        record[3] = 3;
        record[5] = 5;

        print(record[3]);
        print(record[5]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
