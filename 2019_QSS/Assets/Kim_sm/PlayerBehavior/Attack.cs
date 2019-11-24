using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attack : MonoBehaviour
{
    public Image coolDown;

    private GameObject player;
    private GameObject pistol;
    private GameObject rifle;
    private GameObject shotgun;
    private GameObject crossbow;
    private GameObject bat;

    private static bool reloadCheck = false;

    private bool nowReloading = false;
    private int weapon;
    private Transform BulletLocation;
    private Transform GunRotation;
    private Button AttackButton;
    private static float reloadTime;
    private readonly Vector3 addAngle = new Vector3(0, 0, -90);

    public static void SetReloadTime(float thatTime)
    {
        reloadTime = thatTime;
        reloadCheck = true;
    }

    private void Awake()
    {
        AttackButton = this.transform.GetComponent<Button>();
        AttackButton.onClick.AddListener(UserAttack);
        player = GameObject.Find("Player");
        pistol = player.transform.GetChild(0).gameObject;
        rifle = player.transform.GetChild(3).gameObject;
        shotgun = player.transform.GetChild(4).gameObject;
        crossbow = player.transform.GetChild(2).gameObject;
        weapon = Selector();
        //ShotgunBaseBullet.Initalize(BulletLocation, GunRotation);
        //ShotgunBaseBullet.StartCoroutine();
        //CrosbowBaseBullet.Initalize(BulletLocation, GunRotation);
        //CrosbowBaseBullet.StartCoroutine();
    }

    private void Update()
    {
        if (reloadCheck)
        {
            reloadCheck = false;
            nowReloading = true;
            coolDown.fillAmount = 0;
        }
        if (nowReloading)
        {
            if (coolDown.fillAmount < 1)
                coolDown.fillAmount += 1f/reloadTime*Time.deltaTime;
            else
                nowReloading = false;
        }
    }

    public int Selector()
    {
        if (pistol.activeSelf)
        {
            PistolBaseBullet.Initalize(pistol.transform.GetChild(0), pistol.transform);
            PistolBaseBullet.StartCoroutine();
            return 1;
        }
        if (rifle.activeSelf)
        {
            RifleBaseBullet.Initalize(rifle.transform.GetChild(0), rifle.transform);
            RifleBaseBullet.StartCoroutine();
            return 2;
        }
        if (shotgun.activeSelf)
        {
            ShotgunBaseBullet.Initalize(shotgun.transform.GetChild(0), shotgun.transform);
            ShotgunBaseBullet.StartCoroutine();
            return 3;
        }
        if (crossbow.activeSelf)
        {
            CrosbowBaseBullet.Initalize(crossbow.transform.GetChild(0), crossbow.transform);
            CrosbowBaseBullet.StartCoroutine();
            return 4;
        }
        return 0;
    }
    
    public void UserAttack()
    {
        switch (weapon)
        {
            case 1:PistolBaseBullet.StartPistolDelayCoroutine(); break;
            case 2:RifleBaseBullet.StartRifleDelayCoroutine(); break;
            case 3:ShotgunBaseBullet.StartshotgunDelayCoroutine(); break;
            case 4:CrosbowBaseBullet.StartCrosbowDelayCoroutine(); break;
        }
        //PistolBaseBullet.ShotPistolBullet();
        //ShotgunBaseBullet.StartshotgunDelayCoroutine();
        //CrosbowBaseBullet.StartCrosbowDelayCoroutine();
        /*
        BulletManager.BulletInfo bulletinfo = ObjectPoolManager.Dequeue(BulletManager.BulletType.Base);
        bulletinfo.Bullet.position = BulletLocation.position;
        bulletinfo.Bullet.eulerAngles = GunRotation.eulerAngles + addAngle;
        
        Transform b = Instantiate<Transform>(bullet.transform, BulletLocation.position, GunRotation.rotation);
        b.eulerAngles += new Vector3(0, 0, -90);
        */
    }
}
