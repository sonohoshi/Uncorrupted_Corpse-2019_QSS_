using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPenetration : MonoBehaviour
{
    private float bulletDamage;
    public BulletPenetration Instance { get; private set; }
    /*private GameObject pistol;
    private GameObject rifle;
    private GameObject shotgun;

    private void Awake()
    {
        pistol = GameObject.Find("Pistol");
        rifle = GameObject.Find("Rifle");
        shotgun = GameObject.Find("Shotgun");
    }*/

    private void Awake()
    {
        Instance = this;
        DamageInitialize();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
            gameObject.SetActive(false);
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
