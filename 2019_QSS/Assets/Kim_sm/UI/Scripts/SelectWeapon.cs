using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectWeapon : MonoBehaviour
{
    public Transform weapon;
    public Transform player;
    public GameObject coverBTN;
    public AttackBTN atkBTN;

    public void Select()
    {
        Instantiate(weapon, player);
        if (weapon.name.Equals("Crossbow"))
        {
            atkBTN.GetComponent<AttackBTN>().SetWeapon(BulletManager.BulletType.BaseVolt);
        }
        else
        {
            atkBTN.GetComponent<AttackBTN>().SetWeapon(BulletManager.BulletType.Base);
        }
        ZombieSpawner.StartGame();
        BaseBulletPool.StartCoroutine();
        SilverBulletPool.StartCoroutine();
        BaseVoltPool.StartCoroutine();
        SilverVoltPool.StartCoroutine();
        coverBTN.SetActive(false);
        transform.parent.gameObject.SetActive(false);
    }
}
