using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test21 : MonoBehaviour
{
    //코루틴은 병렬처리 개념이다.
    Coroutine myCoroutine1;
    Coroutine myCoroutine2;
    private IEnumerator myCoroutine3;

    // Start is called before the first frame update
    void Start()
    {
        //LoopA();
        //LoopB();
        //myCoroutine1 = StartCoroutine(LoopA());
        myCoroutine3 = LoopA(); // parameter가 굉장히 만을 때 유리하다.
        StartCoroutine(myCoroutine3);
        //myCoroutine2 = StartCoroutine(LoopB());
        StartCoroutine("LoopB"); // 문자열이 성능상 불리하다. 최대 넘길 수 있는 parameter가 한 개 이다.
        StartCoroutine(Stooooop());
    }

    #region Loop
    IEnumerator LoopA()
    {
        for(int i = 0; i < 100; i++)
        {
            print("i의 값 = " + i);
            yield return new WaitForSeconds(1f);
        }
    }

    IEnumerator LoopB()
    {
        for(int x=0; x < 100; x++)
        {
            print("x의 값 = " + x);
            yield return new WaitForSeconds(1f);
        }
    }
    #endregion Loop


    IEnumerator Stooooop()
    {
        yield return new WaitForSeconds(2f);
        //StopCoroutine(myCoroutine1);
        //StopCoroutine(myCoroutine3);
        StopAllCoroutines();
        //yield return new WaitForSeconds(2f);
        //StopCoroutine(myCoroutine2);
        //StopCoroutine("LoopB");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
