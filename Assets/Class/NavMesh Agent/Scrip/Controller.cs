using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 5.0f;
    private NavMeshAgent agent;
    
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();   
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            //RaycastHit : ������ �浹�� ������Ʈ�� ���� ������ �����Ѵ�.
            RaycastHit hit;

            //ī�޶�κ��� ��ũ�� ������ ���콺 �����͸� ���� ��ġ ������ �����Ѵ�.
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                Move(hit.point);
            }
        }
    }

    public void Move(Vector3 Position)
    {
        agent.speed = speed;
        agent.SetDestination(Position);
    }
}
