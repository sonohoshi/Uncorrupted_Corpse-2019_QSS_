using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretFire : MonoBehaviour
{
    private bool isZombie = false;
    private Transform bulletLocation;
    private float turretDamage;

    void Awake()
    {
        bulletLocation = this.transform;
        turretDamage = 5f;
    }
    
    void Update()
    {
        TurretAttack();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            isZombie = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            isZombie = false;
        }
    }

    private void TurretAttack()
    {
        if (isZombie)
        {
            BaseBulletPool.Initalize(bulletLocation,bulletLocation);
            var bullet = BaseBulletPool.PoolingBullet().GetComponent<BulletPenetration>();
            bullet.DamageInitialize(turretDamage);
        }
    }
}
