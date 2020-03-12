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
    private readonly float weaponDamage = 50f;

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
        if (!isReloading && !isShotting && dirBullet > 0)
        {
            switch (bulletType)
            {
                case BulletManager.BulletType.BaseVolt:
                    BaseVoltPool.Initalize(bulletLocation,gunRotation);
                    var baseVolt = BaseVoltPool.PoolingBullet().GetComponent<BaseVoltPenetration>();
                    baseVolt.SetPenetrationSize();
                    baseVolt.DamageInitialize(weaponDamage);
                    break;
                case BulletManager.BulletType.SilverVolt:
                    SilverVoltPool.Initalize(bulletLocation,gunRotation);
                    var silverVolt = SilverVoltPool.PoolingBullet().GetComponent<SilverVoltPenetration>();
                    silverVolt.SetPenetrationSize();
                    silverVolt.DamageInitialize(weaponDamage + 10f);
                    break;
            }

            dirBullet--;
        }

        else if (dirBullet <= 0)
        {
            StartCoroutine(ReloadDelayManage());
        }
        StartCoroutine(AttackDelayManage());
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
