using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneriecStoneDelete : MonoBehaviour
{
    // Start is called before the first frame update
    //OnBecameInvisible : 게임 오브젝트가 화면 밖으로 이동했을 때 동작하는 함수이다.
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
