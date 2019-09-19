using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Items
{
    protected float Armable_number_bullets;//장전가능한 총알 수
    protected float AttackPower;
    protected float AttackSpeed;
    protected float AttackRange;

    public enum CombinationItem
    {
        Bullet,
        Grenade,
        FragmentMine,
        SilverBullet,
        DotSite,
        Cartridge,
        Bolt,
        SilverBolt,
        FlameBottle
    }

    public enum BasicWeapon
    {
        AssaultRifle,
        ShotGun,
        Crossbow,
        Bat,
        HandGun
    }

    public enum Improved_Weapon
    {
        ReinforcedCrossbow,
        ReinforcedBat,
        CollapseCrossbow,
        CollapseShotGun,
        Lightsaber,
        Laser,
        LaserAssaultRifle
    }
}
