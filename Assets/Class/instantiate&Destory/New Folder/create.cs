using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class create : MonoBehaviour
{
    // Start is called before the first frame update
    //int : ������ ������ ���ִ� �ڷ���(4byte)
    //float : �Ǽ��� ������ �� �ִ� �ڷ���(4byte)
    //char : �ϳ��� ���ڸ� ������ �� �ִ� �ڷ���(1byte)
    //char�� ������ ������ �� �ִ�.
    // string : hello ���ڿ��� ������ �� �ִ� �ڷ���
    //���� �̸��� �ߺ��� �Ǹ� �ȵȴ�.
    //������ �̸��� ���ڷ� �����ؼ��� �ȵȴ�.
    //������ �̸��� ������ ������ �ʴ´�.
    //������ Ư�����ڴ� _�� $�� ���ȴ�.

    //char value1 = 'A';
    //10�� 10������ 0~9
    //2���� 0�Ǵ� 1�� ǥ���� �� �ִ�.
    //����� ����ϴ� ���ڸ� �����ϰ� �Ǹ� ��ǻ�ʹ� ��� ���� 2������ �޾Ƶ��δ�.
    
    //int value_2 = 10;
   // float value = 3.14f;


        
        /*
         * if(10==15)
        { 
            print("10�� 10�� �����ϴ�.");
        }
        else if(12==12)
        {
            print("12�� 12�� �����ϴ�.");
        }
        //print(value1);
        //print(value_2);
        //print(value);
        */
         //�ν����� ����

    public GameObject prefab;
    //public : ��ũ��Ʈ ���ο� �ִ� ������ �����̳� ���� ������Ʈ�� Ȯ���ϰų� ������ �� �ִ�.
    //private : ��ũ��Ʈ ���ο� �ִ� ������ �����̳� ���� ������Ʈ �������� �ʵ��� �����Ѵ�.

    public void GenericCreate()
    {
        //instantiate : ���� ������Ʈ�� �����ϴ� �Լ�
        Instantiate(prefab, new Vector3(0, 5, 0), Quaternion.identity);

    }

    public void PoolCreatre()
    {
        ObjectPool.objepool.GetQueue();
    }
}

