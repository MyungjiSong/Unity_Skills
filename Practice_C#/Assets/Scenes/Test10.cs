using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Myungji;
using Myungji.Studio;

// 협업, 대형 프로젝트, 외부 라이브러리.

namespace Myungji
{

    public class Youtube
    {
        public int subscribe;
    }
    namespace Studio
    {
        public class Youtube
        {
            int like;

            public void SetLike(int value)
            {
                like = value;
            }

            public bool isLike()
            {
                return like != 0;
            }
        }
    }
}
public class Test10 : MonoBehaviour
{

    Myungji.Youtube myungji = new Myungji.Youtube();
    // Start is called before the first frame update
    void Start()
    {
        myungji.subscribe = 5;
        print(myungji.subscribe);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
