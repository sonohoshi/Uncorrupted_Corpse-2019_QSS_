using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Structures : MonoBehaviour
{
    protected float DP;
    protected float HP;
    protected float BasePoint;
    protected float DistWeight;
    public enum StrucutreType
    {
        FoodDepot,
        FoodGenerator,
        WoodWall,
        StoneWall,
        SmallTurret,
        MiddleTurret,
        BigTurret
    }

    protected void Begin()
    {
        HP = 100;
        DP = 50;
        BasePoint = 100;
        DistWeight = 1;
    }
    public float GetPriorityPoints(float distance) {
        return BasePoint - (distance * DistWeight);
    }
    public void Attacked(float atk) {
        HP -= atk; Debug.Log(HP);
        if (HP <= 0) { Destroy(gameObject); }
    }
}
