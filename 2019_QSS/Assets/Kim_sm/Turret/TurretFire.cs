using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretFire : MonoBehaviour
{
    public FindZombie fz;
    
    private bool isZombie = false;
    private Transform bulletLocation;
    private float turretDamage;
    private int mobLayerMask = 1 << 8;
    void Awake()
    {
        bulletLocation = this.transform;
        turretDamage = 5f;
    }
    
    void Update()
    {
        TurretAttack();
    }
/*
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
*/
    private void TurretAttack()
    {
        var target = fz.FindClosestEnemy();
        Vector3 dir = target != null ? target.position - transform.position : Vector3.zero;
        RaycastHit2D hit = Physics2D.Raycast(this.transform.position, dir, 7.0f, mobLayerMask);

        if (hit.collider != null)
        {
            Debug.Log("plz dontkillme");
            BaseBulletPool.Initalize(bulletLocation,bulletLocation);
            var bullet = BaseBulletPool.PoolingBullet().GetComponent<BulletPenetration>();
            bullet.DamageInitialize(turretDamage);
        }
    }
}
