using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tail : MonoBehaviour
{
    public GameObject target;
    Vector3 dir;
    // Update is called once per frame
    void Update()
    {
        dir = target.transform.position - transform.position;
        int speed = 5;
        transform.Translate(dir * speed * Time.deltaTime);
    }
}
