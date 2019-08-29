using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Entity : MonoBehaviour
{
    //protected Transform transform;
    protected float hp;
    protected float speed;
    protected float DP;
    protected float Power;

    protected virtual void Move()
    {

    }

    protected void Attack()
    {
        
    }

    protected void Begin()
    {
        hp = 50;
        
    }
}
