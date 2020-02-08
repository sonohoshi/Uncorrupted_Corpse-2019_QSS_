using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public class MeleeAttack : MonoBehaviour
{
    private bool isMoving;
    private bool isTurn;
    private float coolDown;
    private static Transform playerLocation;
    
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
        MoveBat();
    }
    
    private void CalledAttack()
    {
        if (coolDown > 2f)
        {
            isMoving = true;
            coolDown = 0f;
            AttackBTN.SetReloadTime(2f);
        }
    }

    private void RealAttack()
    {
        attackEffect.gameObject.SetActive(true);
        attackEffect.localPosition = playerLocation.position;
        
    }

    private void MoveBat()
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
