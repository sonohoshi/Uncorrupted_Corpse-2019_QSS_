using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackBTN : MonoBehaviour
{
    public Image coolDown;

    public GameObject Player;
    private Weapon weapon;

    private BulletManager.BulletType bulletType;
    private bool _nowReloading = false;
    private Transform _bulletLocation;
    private Transform _gunRotation;
    private Button _attackButton;
    private static float reloadTime;
    private static bool reloadCheck = false;

    public static void SetReloadTime(float thatTime)
    {
        reloadTime = thatTime;
        reloadCheck = true;
    }

    public void SetWeapon(BulletManager.BulletType type)
    {
        weapon = Player.GetComponentInChildren<Weapon>();
        bulletType = type;
    }
    
    private void Start()
    {
        _attackButton = this.transform.GetComponent<Button>();
        _attackButton.onClick.AddListener(UserAttack);
    }

    private void Update() // 현재 업데이트에서는 재장전 버튼 UI 조작 이외의 행동을 하지 않음.
    {
        if (reloadCheck)
        {
            reloadCheck = false;
            _nowReloading = true;
            coolDown.fillAmount = 0;
        }
        if (_nowReloading)
        {
            if (coolDown.fillAmount < 1)
                coolDown.fillAmount += 1f/reloadTime*Time.deltaTime;
            else
                _nowReloading = false;
        }
    }

    private void UserAttack()
    {
        Debug.Log(weapon);
        switch (bulletType)
        {
            case BulletManager.BulletType.Base:
                weapon.WeaponAttack(BulletManager.BulletType.Base);
                Debug.Log("base");
                break;
            case BulletManager.BulletType.Silver:
                weapon.WeaponAttack(BulletManager.BulletType.Silver);
                Debug.Log("silver");
                break;
            case BulletManager.BulletType.BaseVolt:
                weapon.WeaponAttack(BulletManager.BulletType.BaseVolt);
                Debug.Log("volt");
                break;
            case BulletManager.BulletType.SilverVolt:
                weapon.WeaponAttack(BulletManager.BulletType.SilverVolt);
                Debug.Log("svolt");
                break;
        }
    }
}
