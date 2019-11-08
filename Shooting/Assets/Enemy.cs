using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{



    public GameObject exploFactory;
    //타겟을 쫓아간다
    public Transform target;
    Vector3 dir;
    int speed = 7;
    // Start is called before the first frame update
    void Start()
    {        
        target = GameObject.Find("Player").transform;
        //방향 = 목표 - 내 위치;
        dir = target.position - transform.position;
        dir.Normalize();

    }

    // Update is called once per frame
    void Update()
    {        
        transform.Translate(dir * speed * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        //print("물리충돌");
        Destroy(collision.gameObject);
        Destroy(gameObject);

        GameObject explo = Instantiate(exploFactory);
        explo.transform.position = transform.position;
        GameObject km = GameObject.Find("KillMgr");
        KillMgr kill = km.GetComponent<KillMgr>();
        kill.AddKill();
    }
}
