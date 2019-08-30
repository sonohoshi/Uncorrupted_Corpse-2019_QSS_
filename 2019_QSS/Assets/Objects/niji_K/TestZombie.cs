using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestZombie : Zombie
{
    private GameObject target;
    private GameObject[] list;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("FoodDepot");
        if (target != null) Debug.Log("!");
        speed = 3;
    }

    // Update is called once per frame
    void Update()
    {
        list = GameObject.FindGameObjectsWithTag("Target");
        foreach (GameObject obj in list) {
            if (obj.GetComponent<Entity>().GetDP() > target.GetComponent<Structures>().GetDP()) {
                target = obj;
            }
        }
        Vector3 dir = (target.transform.position - transform.position);

        transform.Translate(dir.normalized * speed * Time.deltaTime);
    }
}
