using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Entity : MonoBehaviour
{
    //protected Transform transform;
    protected static float HP;
    protected static float speed;
    protected static float DP;
    protected static float Power;

    protected void Move()
    {

    }

    protected void Attack()
    {
        
    }

    protected void Begin()
    {
        HP = 100;
        DP = 5;
        speed = 3;
        Power = 10;
    }

    //HP, DP 등을 불러올 필요가 있을 때는 이걸 씁시다. (캡슐화)
    public static float[] GetStats() {
        float[] stat = { HP, speed, DP, Power};
        return stat;
    }
}
