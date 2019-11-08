using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : Entity
{
    private float BasePoint;
    private float DistWeight;
    void Start() 
    {
        Begin();
        BasePoint = 30;
        DistWeight = 1;
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

    public static void PlusHealth(int heal)
    {
        HP += heal;
    }
}
