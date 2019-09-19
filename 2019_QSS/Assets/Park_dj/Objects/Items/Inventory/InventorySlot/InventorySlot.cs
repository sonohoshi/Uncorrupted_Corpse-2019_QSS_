using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public Text itemName_Text;
    public Text itemCnt_Text;
    public Text Item_Description;
    public Items Item;

    public void ShowItem(Items _item)
    {
        itemName_Text.text = _item.ItemName;
        if (_item.ItemCNT > 0)
            itemCnt_Text.text = "X " + _item.ItemCNT.ToString();
        else
            itemCnt_Text.text = "X 0";
        Item_Description.text = _item.ItemCombination;
    }


    public void ItemPress()
    {
        ShowItem(Item);    
    }
}
