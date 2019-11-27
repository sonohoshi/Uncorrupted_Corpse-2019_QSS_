using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WearItemButton : MonoBehaviour
{
    public Text ErrorMessage;
    public Text ItemCnt;
    public Text ItemName;
    public static int _ItemNumber;
    public void ReadItemNumber()
    {
        if (_ItemNumber == 0)
        {
            ErrorMessage.text = "해당 아이템을 가지고 있지 않습니다.";
            ItemCnt.text = "";
            ItemName.text = "";
        }
        else
        {
            if (Inventory.TabType == 2)
            {
                if (_ItemNumber == 1 || _ItemNumber == 2 || _ItemNumber == 3)
                {
                    if (WearItems.WearCloseRangeWeapon == _ItemNumber)
                        ErrorMessage.text = "이미 장착중인 아이템입니다.";
                    else
                    {
                        ErrorMessage.text = "아이템이 장착되었습니다.";
                        ItemCnt.text = "";
                        ItemName.text = "";
                        WearItems.WearCloseRangeWeapon = _ItemNumber;
                    }
                }
                else
                {
                    if (WearItems.WearRangedWeapon == _ItemNumber)
                        ErrorMessage.text = "이미 장착중인 아이템입니다.";
                    else
                    {
                        ErrorMessage.text = "아이템이 장착되었습니다.";
                        ItemCnt.text = "";
                        ItemName.text = "";
                        WearItems.WearRangedWeapon = _ItemNumber;
                    }
                }
            }
            else if (Inventory.TabType == 3)
            {
                if (WearItems.WearOneTimeWeapon == _ItemNumber)
                    ErrorMessage.text = "이미 장착중인 아이템입니다.";
                else
                {
                    ErrorMessage.text = "아이템이 장착되었습니다.";
                    ItemCnt.text = "";
                    ItemName.text = "";
                    WearItems.WearOneTimeWeapon = _ItemNumber;
                }
            }
            else if (Inventory.TabType == 4)
            {
                if (WearItems.WearArmor == _ItemNumber)
                    ErrorMessage.text = "이미 장착중인 아이템입니다.";
                else
                {
                    ErrorMessage.text = "아이템이 장착되었습니다.";
                    ItemCnt.text = "";
                    ItemName.text = "";
                    WearItems.WearArmor = _ItemNumber;
                }
            }
        }       
    }
}
