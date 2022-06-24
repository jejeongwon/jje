using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneriecStoneDelete : MonoBehaviour
{
    // Start is called before the first frame update
    //OnBecameInvisible : ���� ������Ʈ�� ȭ�� ������ �̵����� �� �����ϴ� �Լ��̴�.
    Rigidbody rigid;

    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    private void OnBecameInvisible()
    {
        if (gameObject.name == "Stone_3(Clone)")
        {
            Destroy(gameObject);
        }
        else if(gameObject.name == "Stone_5(Clone)")
        {
            ObjectPool.objepool.InsertQueue(gameObject);
        }

     }

    
}
