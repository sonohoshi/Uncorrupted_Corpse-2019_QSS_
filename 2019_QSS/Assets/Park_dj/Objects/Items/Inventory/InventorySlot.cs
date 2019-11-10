using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public int ItemNumber;
    public static bool CanWearItem = false;

    public Text itemName_Text;
    public Text itemCnt_Text;
    public Text Item_Description;
    public Items Item;

    public void ShowItem(Items _item)
    {
        itemName_Text.text = _item.ItemName;
        if (_item.ItemCNT > 0)
        {
            itemCnt_Text.text = "X " + _item.ItemCNT.ToString();
            WearItemButton._ItemNumber = ItemNumber;
        }
        else
        {
            WearItemButton._ItemNumber = 0;
            itemCnt_Text.text = "X 0";
        }          
        Item_Description.text = _item.ItemDescription;
    }


    public void ItemPress()
    {              
        ShowItem(Item);
        if (ItemNumber >= 1 && ItemNumber <= 12)
            CanWearItem = true;       
        else
            CanWearItem = false;
    }
}
