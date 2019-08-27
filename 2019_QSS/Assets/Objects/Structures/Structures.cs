using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Structures : MonoBehaviour
{
    protected float DP;
    protected float HP;
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

    protected void begin()
    {
        HP = 0;
        DP = 0;
    }
}
