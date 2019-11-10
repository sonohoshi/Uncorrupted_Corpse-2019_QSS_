using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MakeItemButton : MonoBehaviour
{
    public Text ItemCnt;

    public GameObject ErrorMessageUI;
    public Text ErrorMessage;
    public static bool ErrorMessageUIisOnOff;
    public static bool AlreadyHave;
    //1회성 아이템 클릭 판단
    public static int ClickOnetimeWeaponItem = 0;
    public static int CanMakeOnetimeWeaponItem = 0;
    public static int MakeOnetimeWeapon = 0;
    //업그레이드 무기 클릭 판단
    public static int ClickUpgradeWeapon = 0;
    public static int CanMakeUpgradeWeapon = 0;
    public static int MakeUpgradeWeapon = 0;
    //갑옷 클릭 판단
    public static int ClickArmor = 0;
    public static int CanMakeArmor = 0;
    public static int MakeArmor = 0;

    private void Start()
    {
        ErrorMessageUI.SetActive(false);
        ErrorMessageUIisOnOff = false;
        AlreadyHave = false;
    }

    public void DoMakeItem()
    {
        if (ShowRecipeButton.isOnOff == false && ErrorMessageUIisOnOff == false)
        {
            if (CanMakeOnetimeWeaponItem != 0)
            {
                if (CanMakeOnetimeWeaponItem == 1)
                {
                    Gunpowder.cnt--;
                    ScrapMetal.cnt--;
                    Bullet.cnt++;
                    ItemCnt.text = "X " + Bullet.cnt.ToString();
                    MakeOnetimeWeapon = 1;
                }
                else if (CanMakeOnetimeWeaponItem == 2)
                {
                    Gunpowder.cnt--;
                    Silver.cnt--;
                    SilverBullet.cnt++;
                    ItemCnt.text = "X " + SilverBullet.cnt.ToString();
                    MakeOnetimeWeapon = 2;
                }
                else if (CanMakeOnetimeWeaponItem == 3)
                {
                    ScrapMetal.cnt--;
                    Branch.cnt--;
                    Bolt.cnt++;
                    ItemCnt.text = "X " + Bolt.cnt.ToString();
                    MakeOnetimeWeapon = 3;
                }
                else if (CanMakeOnetimeWeaponItem == 4)
                {
                    Silver.cnt--;
                    Branch.cnt--;
                    SilverBolt.cnt++;
                    ItemCnt.text = "X " + SilverBolt.cnt.ToString();
                    MakeOnetimeWeapon = 4;
                }
                else if (CanMakeOnetimeWeaponItem == 5)
                {
                    Gunpowder.cnt -= 2;
                    ScrapMetal.cnt--;
                    Grenade.cnt++;
                    ItemCnt.text = "X " + Grenade.cnt.ToString();
                    MakeOnetimeWeapon = 5;
                }
                else if (CanMakeOnetimeWeaponItem == 6)
                {
                    Gunpowder.cnt -= 2;
                    Glass.cnt--;
                    FragmentMine.cnt++;
                    ItemCnt.text = "X " + FragmentMine.cnt.ToString();
                    MakeOnetimeWeapon = 6;
                }
                else if (CanMakeOnetimeWeaponItem == 7)
                {
                    Lighter.cnt--;
                    Glass.cnt--;
                    FragmentMine.cnt++;
                    ItemCnt.text = "X " + FragmentMine.cnt.ToString();
                    MakeOnetimeWeapon = 7;
                }
                else if (CanMakeOnetimeWeaponItem == 8)
                {
                    LaserPointer.cnt--;
                    Glass.cnt--;
                    DotSite.cnt++;
                    ItemCnt.text = "X " + DotSite.cnt.ToString();
                    MakeOnetimeWeapon = 8;
                }
                CanMakeOnetimeWeaponItem = 0;
            }//1회성 아이템 제작 및 재료 삭제
            else if (CanMakeUpgradeWeapon != 0)
            {
                if (CanMakeUpgradeWeapon == 1)
                {
                    Bat.cnt--;
                    Nail.cnt--;
                    Glue.cnt--;
                    ReinforcedBat.cnt++;
                    ItemCnt.text = "X " + ReinforcedBat.cnt.ToString();
                    MakeUpgradeWeapon = 1;
                }
                else if (CanMakeUpgradeWeapon == 2)
                {
                    Bat.cnt--;
                    LaserPointer.cnt--;
                    RadioactivityX.cnt--;
                    Lightsaber.cnt++;
                    ItemCnt.text = "X " + Lightsaber.cnt.ToString();
                    MakeUpgradeWeapon = 2;
                }
                else if (CanMakeUpgradeWeapon == 3)
                {
                    Crossbow.cnt--;
                    Wire.cnt--;
                    Glue.cnt--;
                    ReinforcedBat.cnt++;
                    ItemCnt.text = "X " + ReinforcedBat.cnt.ToString();
                    MakeUpgradeWeapon = 3;
                }
                else if (CanMakeUpgradeWeapon == 4)
                {
                    Crossbow.cnt--;
                    Wire.cnt--;
                    RadioactivityX.cnt--;
                    CollapseCrossbow.cnt++;
                    ItemCnt.text = "X " + CollapseCrossbow.cnt.ToString();
                    MakeUpgradeWeapon = 4;
                }
                else if (CanMakeUpgradeWeapon == 5)
                {
                    AssaultRifle.cnt--;
                    LaserPointer.cnt--;
                    RadioactivityX.cnt--;
                    LaserAssaultRifle.cnt++;
                    ItemCnt.text = "X " + LaserAssaultRifle.cnt.ToString();
                    MakeUpgradeWeapon = 5;
                }
                else if (CanMakeUpgradeWeapon == 6)
                {
                    Handgun.cnt--;
                    LaserPointer.cnt--;
                    RadioactivityX.cnt--;
                    LaserHandGun.cnt++;
                    ItemCnt.text = "X " + LaserHandGun.cnt.ToString();
                    MakeUpgradeWeapon = 6;
                }
                else if (CanMakeUpgradeWeapon == 7)
                {
                    Shotgun.cnt--;
                    Silver.cnt--;
                    RadioactivityX.cnt--;
                    CollapseShotGun.cnt++;
                    ItemCnt.text = "X " + CollapseShotGun.cnt.ToString();
                    MakeUpgradeWeapon = 7;
                }
                CanMakeUpgradeWeapon = 0;
            }// 업그레이드 무기 제작 및 재료 삭제
            else if (CanMakeArmor != 0)
            {
                if (CanMakeArmor == 1)
                {
                    Fabric.cnt--;
                    Thread.cnt--;                   
                    Clothes.cnt++;
                    ItemCnt.text = "X " + Clothes.cnt.ToString();
                    MakeArmor = 1;
                }
                else if (CanMakeArmor == 2)
                {
                    Clothes.cnt--;
                    ScrapMetal.cnt--;
                    Armor.cnt++;
                    ItemCnt.text = "X " + Armor.cnt.ToString();
                    MakeArmor = 2;
                }
                else if (CanMakeArmor == 3)
                {
                    Clothes.cnt--;
                    Silver.cnt--;
                    SilverArmor.cnt++;
                    ItemCnt.text = "X " + SilverArmor.cnt.ToString();
                    MakeArmor = 3;
                }
                CanMakeArmor = 0;
            }// 갑옷 제작 및 제료 삭제
            else
            {
                ErrorMessageUIisOnOff = true;
                ErrorMessageUI.SetActive(true);
                if (AlreadyHave == true)
                {
                    ErrorMessage.text = "이미 아이템을 소지하고 있습니다.";
                    AlreadyHave = false;
                }
                else
                {
                    ErrorMessage.text = "재료가 부족하여 아이템을 제작할 수 없습니다.";
                }
            }// 에러 검출
        }
    }
}
