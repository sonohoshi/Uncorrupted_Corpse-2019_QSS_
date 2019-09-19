using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : Entity
{
    protected float Structure_Attack;

    public enum ZombieType
    {
       CommonZombie,
       ZombieDog,
       MegalZombie,
       BloodGunZombie,
       PoliceZombie
    }

    public enum BossZombie
    {
        BigZzangZzangSanZombie
    }
}
