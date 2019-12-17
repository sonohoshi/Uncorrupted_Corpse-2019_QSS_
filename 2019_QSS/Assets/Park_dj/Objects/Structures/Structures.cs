using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Structures : MonoBehaviour
{
    protected float DP;
    protected float HP;
    protected float BasePoint;
    protected float DistWeight;
    public enum StrucutreType : int
    {
        FoodDepot = 0,
        FoodGenerator = 1,
        WoodWall = 2,
        StoneWall = 3,
        SmallTurret = 4,
        MiddleTurret = 5,
        BigTurret = 6
    }

    protected void Begin(float hp, float dp, float bp, float dist)
    {
        HP = hp;
        DP = dp;
        BasePoint = bp;
        DistWeight = dist;
        GetComponent<Rigidbody2D>().mass = DP;
    }
    public float GetPriorityPoints(float distance) {
        return BasePoint - (distance * DistWeight);
    }

    public float[] GetStats()
    {
        float[] stat = { HP, DP, BasePoint, DistWeight };
        return stat;
    }

    public void Attacked(float atk) {
        HP -= atk - DP; 
#if UNITY_EDITOR
        Debug.Log(HP);
#endif
        if (HP <= 0) { Destroy(gameObject); }
    }
}
