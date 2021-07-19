using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour // 여기 'Test' 이름과 Unity의 C#의 이름이 모두 일치해야 한다.
{

    int x = 100;
    int y = 100;
    int sum;

    // Start is called before the first frame update
    void Start()
    {
        sum = x + y;
        print(sum);

        print(-sum);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
