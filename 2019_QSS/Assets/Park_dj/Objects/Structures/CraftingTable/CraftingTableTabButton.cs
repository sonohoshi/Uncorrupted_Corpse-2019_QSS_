using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CraftingTableTabButton : MonoBehaviour
{
    public Text item_Name_Text;
    public Text Item_Description_text;
    public Text item_Cnt_Text;

    public void WeaponButtonActive()
    {
        CraftingTable.TabType = 1;
        item_Name_Text.text = "";
        item_Cnt_Text.text = "";
        Item_Description_text.text = "좀비를 죽일 때 사용하는 장착형 무기를 제작합니다.";
        MakeItemButton.CanMakeUpgradeWeapon = 0;
        MakeItemButton.ClickOnetimeWeaponItem = 0;
        MakeItemButton.ClickUpgradeWeapon = 0;
    }
    public void OneTimeWeaponButtonActive()
    {
        CraftingTable.TabType = 2;
        item_Name_Text.text = "";
        item_Cnt_Text.text = "";
        Item_Description_text.text = "일회용으로 사용하 수 있는 무기와 탄약을 제작합니다.\n일회용 무기는 모두 적의 방어력을 무시합니다.";
        MakeItemButton.CanMakeOnetimeWeaponItem = 0;
        MakeItemButton.ClickOnetimeWeaponItem = 0;
        MakeItemButton.ClickUpgradeWeapon = 0;
    }
    public void ArmorButtonActive()
    {
        CraftingTable.TabType = 3;
        item_Name_Text.text = "";
        item_Cnt_Text.text = "";
        Item_Description_text.text = "방어력을 올려주는 갑옷을 제작합니다.";
        MakeItemButton.CanMakeOnetimeWeaponItem = 0;
        MakeItemButton.ClickOnetimeWeaponItem = 0;
        MakeItemButton.ClickUpgradeWeapon = 0;
    }
}
