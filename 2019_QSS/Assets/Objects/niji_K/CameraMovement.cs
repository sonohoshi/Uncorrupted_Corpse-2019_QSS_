using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    GameObject plr; //플레이어
    // Start is called before the first frame update
    void Start()
    {
        plr = FindObjectOfType<TestZombie>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 tmp = plr.transform.position;
        transform.position = new Vector3(tmp.x, tmp.y, transform.position.z);
    }
}
