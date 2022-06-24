using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    // Start is called before the first frame update
    //�ڷᱸ��
    //Queue : ���� ���� ���� �����Ͱ� ���� ���� ������ �����̴�.
    //static : ������ ����ɶ����� �޸𸮿� ���� �ִ�.
   
    public static ObjectPool objepool;
    
    public GameObject prefab;
   
    public Queue<GameObject> queue = new Queue<GameObject>();


    private void Start()
    {
        objepool = this;

        //1. �ʱⰪ�� �����Ѵ�.
        //2. ���ǽ��� �����Ѵ�.
        //3. ��ɹ��� �ѹ� �����Ѵ�.
        //4. �ʱⰪ�� ������Ų��.
        for(int i = 0; i < 5; i++)
        {
           GameObject tempPrefab = Instantiate(prefab, new Vector3(0, 5, 0), (Quaternion.identity));
            queue.Enqueue(tempPrefab);
            tempPrefab.SetActive(false);
        }
    }

    public void InsertQueue(GameObject tObject)
    {
        queue.Enqueue(tObject);
        tObject.SetActive(false);
    }

    public GameObject GetQueue()
    {
        GameObject tempObject = queue.Dequeue();
        tempObject.SetActive(true);

        return tempObject;
    }
}
