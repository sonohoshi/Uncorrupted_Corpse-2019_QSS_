using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class WeaponRifle : Weapon
{
    private bool isShotting;
    private bool isReloading;
    private int dirBullet;
    
    private readonly float reloadTime = 2f;
    private readonly int maxBullet = 20;
    private readonly float fireDelay = 0.25f;
    private readonly float weaponDamage = 10f;

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
            BulletPenetration bullet;
            switch (bulletType)
            {
                case BulletManager.BulletType.Base:
                    BaseBulletPool.Initalize(bulletLocation,gunRotation);
                    bullet = BaseBulletPool.PoolingBullet().GetComponent<BulletPenetration>();
                    bullet.DamageInitialize(weaponDamage);
                    break;
                case BulletManager.BulletType.Silver:
                    SilverBulletPool.Initalize(bulletLocation,gunRotation);
                    bullet = SilverBulletPool.PoolingBullet().GetComponent<BulletPenetration>();
                    bullet.DamageInitialize(weaponDamage + 5f);
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