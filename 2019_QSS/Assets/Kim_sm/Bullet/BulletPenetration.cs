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
        DamageInitialize();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy")) gameObject.SetActive(false);
        if(collision.gameObject.CompareTag("Wall")) gameObject.SetActive(false);
    }

    private void DamageInitialize()
    {
        Debug.Log(gameObject.name);
        if (gameObject.name.Equals("BaseBullet(Clone)"))
            bulletDamage = 10f + 5f;
        else if (gameObject.name.Equals("SilverBullet(Clone)"))
            bulletDamage = 10f + 10f;
        Debug.Log("Bullet Damage : " + bulletDamage);
    }

    public float GetBulletDamage()
    {
        return bulletDamage;
    }
}
