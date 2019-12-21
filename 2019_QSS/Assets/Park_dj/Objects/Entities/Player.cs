using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity
{
    private float BasePoint;
    private float DistWeight;
    void Start()
    {
        Begin(500, 5, 5, 10, 30, 1);
    }
    protected void Begin(float hp, float dp, float sp, float pow, float bp, float dist)
    {
        HP = hp;
        DP = dp;
        speed = sp;
        Power = pow;
        BasePoint = bp;
        DistWeight = dist;
        GetComponent<Rigidbody2D>().mass = DP;
    }

    private void Update()
    {
        if (transform.parent.position != transform.position)
            transform.position = transform.parent.position;
    }

    public float GetPriorityPoints(float distance)
    {
        return BasePoint - (distance * DistWeight);
    }

    protected void UseWeapon()
    {

    }

    protected void Inventory()
    {

    }

    public void PlusHealth(int heal)
    {
        HP += heal;
    }

    public void Attacked(float atk)
    {
        HP -= atk - DP;
        if (HP <= 0) { Destroy(transform.parent.gameObject); }
    }
}
