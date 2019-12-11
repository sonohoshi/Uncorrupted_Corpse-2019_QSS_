using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeAttack : MonoBehaviour
{
    private bool isMoving;
    private bool isTurn;
    private float coolDown;
    public Transform attackEffect;

    void Awake()
    {
        isTurn = false;
        isMoving = false;
        coolDown = 0f;
    }
    
    void Update()
    {
        coolDown += Time.deltaTime;
        moveBat();
    }
    
    private void calledAttack()
    {
        if (coolDown > 2f)
        {
            isMoving = true;
            coolDown = 0f;
        }
    }

    private void moveBat()
    {
        if (isMoving)
        {
            if (!isTurn)
            {
                transform.eulerAngles = new Vector3(0, 0, -1);
                if (transform.rotation.z <= -90)
                    isTurn = true;
            }else
            {
                transform.eulerAngles = new Vector3(0,0,1);
                if (transform.rotation.z >= -20)
                    isMoving = false;
            }
        }
        
    }
    
}
