using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food_Depot : Structures
{
    private GameObject F_D_Interection;
    public GameObject[] zombie; //생성할 좀비 목록
    public static bool interaction = false;
    public static int food = 1000;
    private int frame_count = 0;

    private void Start()
    {   
        Begin();
        HP = 2000;    
    }
        
    void Update()
    {
        frame_count++;
        if (frame_count % 120 == 0) 
        {
            float dist = Random.Range(16.0f, 20.0f);
            float angle = Random.Range(-Mathf.PI, Mathf.PI);
            Vector3 pos = transform.position;
            pos += new Vector3(Mathf.Cos(angle), Mathf.Sin(angle), 0) * dist;
            Instantiate(zombie[Random.Range(0,zombie.Length)], pos, new Quaternion(0,0,0,0));
        }
        if(interaction == true)
        {
          //  F_D_Interection.SetActive(true);
        }
        else if(interaction == false)
        {
           // F_D_Interection.SetActive(false);
        }
    }       
}
