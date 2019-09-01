using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestZombie : Zombie
{
    private GameObject target;
    private GameObject[] list;
    private int cnt = 0;
    // Start is called before the first frame update
    void Start()
    {
        speed = 3;
        Power = 10;
    }

    // Update is called once per frame
    void Update()
    {
        list = GameObject.FindGameObjectsWithTag("Target");
        target = list[0];

        Vector3 dir = new Vector3();
        foreach (GameObject obj in list) {
            dir = (target.transform.position - transform.position);
            float cmpdist = (obj.transform.position - transform.position).magnitude;

            if (obj.GetComponent<Structures>().GetDP()-cmpdist > target.GetComponent<Structures>().GetDP()-dir.magnitude) {
                target = obj;
            }
        }

        transform.Translate(dir.normalized * speed * Time.deltaTime);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        cnt++;
        if (cnt % 5 == 0)
        {
            collision.gameObject.GetComponent<Structures>().Attacked(Power);
        }
    }
}
