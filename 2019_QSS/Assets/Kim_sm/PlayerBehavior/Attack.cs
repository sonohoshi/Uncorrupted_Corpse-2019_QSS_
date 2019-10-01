using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attack : MonoBehaviour
{
    public GameObject bullet;
    public Transform BulletLocation;
    public Transform GunRotation;
    public float BulletDelay;

    private readonly Vector3 addAngle = new Vector3(0, 0, -90);

    private void Awake()
    {
        PistolBaseBullet.Initalize(BulletLocation, GunRotation);
        PistolBaseBullet.StartCoroutine();
    }

    public void UserAttack(int WeaponType)
    {
        PistolBaseBullet.ShotBullet();

        //BulletManager.BulletInfo bulletinfo = ObjectPoolManager.Dequeue(BulletManager.BulletType.Base);
        //bulletinfo.Bullet.position = BulletLocation.position;
        //bulletinfo.Bullet.eulerAngles = GunRotation.eulerAngles + addAngle;
        
        // Transform b = Instantiate<Transform>(bullet.transform, BulletLocation.position, GunRotation.rotation);
        // b.eulerAngles += new Vector3(0, 0, -90);
    }
}
