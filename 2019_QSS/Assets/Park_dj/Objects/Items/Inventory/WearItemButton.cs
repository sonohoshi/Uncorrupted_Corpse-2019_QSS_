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
                    WearItems.WearCloseRangeWeapon = _ItemNumber;
                else
                    WearItems.WearRangedWeapon = _ItemNumber;
            }
            else if (Inventory.TabType == 3)
            {
                WearItems.WearOneTimeWeapon = _ItemNumber;
            }
            else if (Inventory.TabType == 4)
            {
                WearItems.WearArmor = _ItemNumber;
            }
            ErrorMessage.text = "아이템이 장착되었습니다.";
            ItemCnt.text = "";
            ItemName.text = "";
        }       
    }
}
