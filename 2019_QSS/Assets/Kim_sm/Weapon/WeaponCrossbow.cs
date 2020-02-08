using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class WeaponCrossbow : Weapon
{
    private bool isShotting;
    private bool isReloading;
    private int dirBullet;
    
    private readonly float reloadTime = 0.5f;
    private readonly int maxBullet = 1;
    private readonly float fireDelay = 0.5f;

    private Transform bulletLocation;
    private Transform gunRotation;

    private void Start()
    {
        bulletLocation = this.transform.GetChild(0);
        gunRotation = this.transform;
        dirBullet = maxBullet;
    }

    public override void WeaponAttack(BulletManager.BulletType bulletType)
    {
        StartCoroutine(AttackDelayManage());
        if (!isReloading && !isShotting)
        {
            switch (bulletType)
            {
                case BulletManager.BulletType.BaseVolt:
                    BaseVoltPool.Initalize(bulletLocation,gunRotation);
                    BaseVoltPool.PoolingBullet();
                    break;
                case BulletManager.BulletType.SilverVolt:
                    SilverVoltPool.Initalize(bulletLocation,gunRotation);
                    SilverVoltPool.PoolingBullet();
                    break;
            }
        }

        else if (dirBullet <= 0)
        {
            StartCoroutine(ReloadDelayManage());
        }
    }

    public override IEnumerator ReloadDelayManage()
    {
        if (!isReloading)
        {
            isReloading = true;
            AttackBTN.SetReloadTime(reloadTime);
            yield return new WaitForSeconds(reloadTime);
            isReloading = false;
            dirBullet = maxBullet;
        }
    }

    public override IEnumerator AttackDelayManage()
    {
        if (!isShotting)
        {
            isShotting = true;
            yield return new WaitForSeconds(fireDelay);
            isShotting = false;
        }
    }
}
