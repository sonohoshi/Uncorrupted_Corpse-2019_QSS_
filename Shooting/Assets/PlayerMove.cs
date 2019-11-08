using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public int speed = 10;
    Vector3 dir = Vector3.right;

    public GameObject Retry;
    bool isTouch = false;

    private void OnDestroy()
    {
        Retry.SetActive(true);
    }

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            isTouch = true;
        }
        if(Input.GetMouseButtonUp(0))
        {
            isTouch = false;
        }
        if(isTouch)
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 13;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            transform.position = mousePos;
        }
        
        //-1 ~ 1
        /*float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 dir = Vector3.right * h;
        Vector3 dir2 = Vector3.up * v;
        //방향*속도*시간
        gameObject.transform.Translate((dir + dir2) * speed * Time.deltaTime);*/
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
