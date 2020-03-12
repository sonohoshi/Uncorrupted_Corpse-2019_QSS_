using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseVoltPenetration : MonoBehaviour
{
    private float penetrationSize = 30;
    private float bulletDamage;
    public static BaseVoltPenetration Instance { get; private set; }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            penetrationSize -= collision.attachedRigidbody.mass;

            if (penetrationSize <= 0) gameObject.SetActive(false);
        }
        if(collision.gameObject.CompareTag("Wall")) gameObject.SetActive(false);
    }

    private void Awake()
    {
        Instance = this;
    }

    public void SetPenetrationSize()
    {
        penetrationSize = 30;
    }
    
    public void DamageInitialize(float damage)
    {
        bulletDamage = damage;
    }

    public float GetBulletDamage()
    {
        return bulletDamage;
    }
}
