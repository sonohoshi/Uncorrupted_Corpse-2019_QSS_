using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Items : MonoBehaviour
{
    //재료, 갑옷, 무기 아이템들에서 공통으로 사용
    public string ItemName;
    public string ItemDescription;
    public int ItemCNT;
    public ItemType Itemtype;
     
    //아이템 조합대에서 사용
    public GameObject EmphasisSquare;
    
    public enum ItemType
    {
        Material,
        OneTimeWeapon,
        ConsumptionBullet,
        Armor,
        Weapon
    }   

    //아이템들의 타입과 이름, 설명(조합식)과 개수 설명
    protected void Material_List(ItemType Item_Type, string Item_Name, string Item_Description, int Item_CNT)
    {
        ItemCNT = Item_CNT;
        Itemtype = Item_Type;
        ItemName = Item_Name;
        ItemDescription = Item_Description;       
    }

    //1회성 아이템 조합 아이템 및 상태 확인
    public void OneTimeWeaponMakeSign(int i, bool _CanMake)
    {
        MakeItemButton.ClickOnetimeWeaponItem = i;
        if (_CanMake == true)
        {
            MakeItemButton.CanMakeOnetimeWeaponItem = i;
        }
        else if (_CanMake == false)
        {
            MakeItemButton.CanMakeOnetimeWeaponItem = 0;
        }
    }
    //무기 아이템에서 사용
    public void UpgradeWeaponMakeSign(int i, bool _CanMake, int _cnt)
    {
        MakeItemButton.ClickUpgradeWeapon = i;
        if (_CanMake == true)
        {
            MakeItemButton.CanMakeUpgradeWeapon = i;
        }
        else if (_CanMake == false)
        {
            MakeItemButton.CanMakeUpgradeWeapon = 0;
            if (_cnt != 0) MakeItemButton.AlreadyHave = true;
            else if (_cnt == 0) MakeItemButton.AlreadyHave = false;
        }
    }
    //방어구 아이템에 사용
    public void ArmorMakeSign(int i, bool _CanMake, int _cnt)
    {
        MakeItemButton.ClickArmor = i;
        if (_CanMake == true)
        {
            MakeItemButton.CanMakeArmor = i;
        }
        else if (_CanMake == false)
        {
            MakeItemButton.CanMakeArmor = 0;
            if (_cnt != 0) MakeItemButton.AlreadyHave = true;
            else if (_cnt == 0) MakeItemButton.AlreadyHave = false;
        }
    }
}
    