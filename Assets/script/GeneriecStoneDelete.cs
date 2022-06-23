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
        if (gameObject.name == "Stone_3(clone)")
            Destroy(gameObject, 10);
    
        else if(gameObject.name == "Stone_5(clone)") 
        ObjectPool.objepool.InsertQueue(gameObject);
     }

    
}
