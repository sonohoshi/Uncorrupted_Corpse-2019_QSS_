using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    /*
    protected bool isShotting;
    protected bool isReloading;
    protected float reloadTime;
    protected int dirBullet;
    protected int maxBullet;*/
    
    public abstract void WeaponAttack(BulletManager.BulletType bulletType);
    public abstract IEnumerator ReloadDelayManage();
    public abstract IEnumerator AttackDelayManage();
}
