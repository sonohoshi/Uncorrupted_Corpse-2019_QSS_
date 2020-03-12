using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class WeaponShotgun : Weapon
{
    private bool isShotting;
    private bool isReloading;
    private int dirBullet;
    
    private readonly float reloadTime = 2f;
    private readonly int maxBullet = 5;
    private readonly float fireDelay = 1f;
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
        Debug.Log(isReloading);
        Debug.Log(isShotting);
        if (!isReloading && !isShotting && dirBullet > 0)
        {
            List<Transform> bulletList;
            switch (bulletType)
            {
                case BulletManager.BulletType.Base:
                    BaseBulletPool.Initalize(bulletLocation,gunRotation);
                    bulletList = BaseBulletPool.AddBullet();
                    foreach (var t in bulletList)
                    {
                        var bullet = t.GetComponent<BulletPenetration>();
                        bullet.DamageInitialize(weaponDamage);
                    }
                    break;
                case BulletManager.BulletType.Silver:
                    SilverBulletPool.Initalize(bulletLocation,gunRotation);
                    bulletList = SilverBulletPool.AddBullet();
                    foreach (var t in bulletList)
                    {
                        var bullet = t.GetComponent<BulletPenetration>();
                        bullet.DamageInitialize(weaponDamage + 5f);
                    }
                    break;
            }
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