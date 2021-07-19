using System.Collections; // 이거에 대해 알려줄 것임
using System.Collections.Generic;
using UnityEngine;

public class Test9 : MonoBehaviour
{
    int[] exp = new int[5] { 1, 2, 3, 4, 5 };

    // 컬렉션 : 리스트 , 큐, 스택, 해시테이블 , 에레이 리스트

    /* ArrayList

    ArrayList arrayList = new ArrayList();

    void ArrayListExample()
    {
        arrayList.Add(1);
        arrayList.Add(2);
        arrayList.Add("가나다라");

        // arrayList.Remove("가나다라");
        // arrayList.RemoveAt(1);
        // arrayList.RemoveRange(0, 1);
        // arrayList.Contains("가나다라"); 특정 원소가 있느냐

        print(arrayList.Count);

        for (int i = 0; i < arrayList.Count; i++)
        {
            print(arrayList[i]);
        }
    }
    */

    /* List - 특정한 자료형 선언을 해 줌
    
    void ListExample()
    {
        List<int> list = new List<int>();
    }
    */

    /* HashTable
    Hashtable hashTable = new Hashtable();

    void HashTableExample()
    {
        hashTable.Add("만", 10000);
        hashTable.Add("백만", 1000000);
        print(hashTable["만"]);
    }
    */

    /* Dictionary - HashTable 의 자료형을 명시해준다 ArrayList 와 List 관계 중 List 와 같음

    Dictionary<string, int> dictionary = new Dictionary<string, int>();
    void DictionaryExample()
    {
        dictionary.Add("가", 100);
    }
    */

    /* Queue, 선입선출, FIFO, 포션 제작 대기줄 (은행 대기줄)

    Queue<int> queue = new Queue<int>();

    void QueueExample()
    {
        queue.Enqueue(5);
        queue.Enqueue(10);
        queue.Dequeue();
    }
    */

    /* Stack, 후입 선출, LIFO, 요리 게임

    Stack<int> stack = new Stack<int>();

    void StackExample()
    {
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Pop();


    }
    */


    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
