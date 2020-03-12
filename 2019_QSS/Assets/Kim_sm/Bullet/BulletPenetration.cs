using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPenetration : MonoBehaviour
{
    private float bulletDamage;
    public BulletPenetration Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy")) gameObject.SetActive(false);
        if(collision.gameObject.CompareTag("Wall")) gameObject.SetActive(false);
    }

    public void DamageInitialize(float damage)
    {
        bulletDamage = damage;
        Debug.Log("Bullet Damage : " + bulletDamage);
    }

    public float GetBulletDamage()
    {
        return bulletDamage;
    }
}
