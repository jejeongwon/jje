using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMent : MonoBehaviour
{
    // const : ���
    // ���� �߿� ���� ����� �� ���� ���̴�.
    const int a = 4;

    int b = 100;

   //a��� ������� ���� ������ �� ������ a�� ������ ������ �����ϴ� ���� �����ϴ�.

    // Start is called before the first frame update
    void Start()
    {
       // a��� �޸� ���� ��� �ٲ� �� �ִ�.
        
        Debug.Log(a + b);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
