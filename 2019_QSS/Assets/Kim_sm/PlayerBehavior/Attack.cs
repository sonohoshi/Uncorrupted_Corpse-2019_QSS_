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
    private Button AttackButton;
    private readonly Vector3 addAngle = new Vector3(0, 0, -90);

    private void Awake()
    {
        AttackButton = this.transform.GetComponent<Button>();
        AttackButton.onClick.AddListener(UserAttack);
        //ShotgunBaseBullet.Initalize(BulletLocation, GunRotation);
        //ShotgunBaseBullet.StartCoroutine();
        CrosbowBaseBullet.Initalize(BulletLocation, GunRotation);
        CrosbowBaseBullet.StartCoroutine();
    }
    
    public void UserAttack()
    {
        //PistolBaseBullet.ShotPistolBullet();
        //ShotgunBaseBullet.StartshotgunDelayCoroutine();
        CrosbowBaseBullet.StartCrosbowDelayCoroutine();
        //BulletManager.BulletInfo bulletinfo = ObjectPoolManager.Dequeue(BulletManager.BulletType.Base);
        //bulletinfo.Bullet.position = BulletLocation.position;
        //bulletinfo.Bullet.eulerAngles = GunRotation.eulerAngles + addAngle;
        
        // Transform b = Instantiate<Transform>(bullet.transform, BulletLocation.position, GunRotation.rotation);
        // b.eulerAngles += new Vector3(0, 0, -90);
    }
}
