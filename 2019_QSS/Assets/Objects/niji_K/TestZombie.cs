using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

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
        //타깃을 모아놓은 리스트.
        GameObject[] list = GameObject.FindGameObjectsWithTag("Structures");
        list = list.Concat(GameObject.FindGameObjectsWithTag("FoodDepot")).ToArray();
        list = list.Concat(GameObject.FindGameObjectsWithTag("Player")).ToArray();
        target = list[0];

        Vector3 dir = new Vector3();
        foreach (GameObject obj in list) {
            dir = (target.transform.position - transform.position);

            float targetdist = dir.magnitude;
            float cmpdist = (obj.transform.position - transform.position).magnitude;

            if (obj.GetComponent<Player>()) {
                if (obj.GetComponent<Player>().GetPriorityPoints(cmpdist) > target.GetComponent<Player>().GetPriorityPoints(targetdist))
                {
                    target = obj;
                }
            }
            else if (obj.GetComponent<Structures>().GetPriorityPoints(cmpdist) > target.GetComponent<Structures>().GetPriorityPoints(targetdist)) {
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
