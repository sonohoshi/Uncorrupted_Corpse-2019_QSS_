using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpperButton : MonoBehaviour
{
    public Text itemName_Text;
    public Text itemCnt_Text;
    public Text Item_Description;


    public void MaterialButtonActive()
    {
        Inventory.TabType = 1;
        itemName_Text.text = "";
        itemCnt_Text.text = "";
        Item_Description.text = "무기, 갑옷, 탄약, 구조물을 만들 때 사용하는 재료입니다.";
        InventorySlot.CanWearItem = false;
        WearItemButton._ItemNumber = 0;
    }
    public void WeaponButtonActive()
    {
        Inventory.TabType = 2;
        itemName_Text.text = "";
        itemCnt_Text.text = "";
        Item_Description.text = "좀비를 죽일 때 사용하는 장착형 무기입니다.";
        InventorySlot.CanWearItem = false;
        WearItemButton._ItemNumber = 0;
    }
    public void OneTimeWeaponButtonActive()
    {
        Inventory.TabType = 3;
        itemName_Text.text = "";
        itemCnt_Text.text = "";
        Item_Description.text = "일회용으로 사용하 수 있는 무기와 탄약입니다.";
        InventorySlot.CanWearItem = false;
        WearItemButton._ItemNumber = 0;
    }
    public void ArmorButtonActive()
    {
        Inventory.TabType = 4;
        itemName_Text.text = "";
        itemCnt_Text.text = "";
        Item_Description.text = "방어력을 올려주는 갑옷입니다.";
        InventorySlot.CanWearItem = false;
        WearItemButton._ItemNumber = 0;
    }
}
