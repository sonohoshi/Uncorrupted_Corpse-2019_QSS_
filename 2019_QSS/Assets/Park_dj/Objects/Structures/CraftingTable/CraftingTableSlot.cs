using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CraftingTableSlot : MonoBehaviour
{
    public Text itemName_Text;
    public Text itemName_Description_Text;
    public Text itemCnt_Text;
    public Items Item;

    public static bool Syntheticpossible = false;


    public void ShowItem(Items _item)
    {
        itemName_Text.text = _item.ItemName;
        itemName_Description_Text.text = _item.ItemDescription;
        if (_item.ItemCNT > 0)
            itemCnt_Text.text = "X " + _item.ItemCNT.ToString();
        else
            itemCnt_Text.text = "X 0";
    }

    public void ItemPress()
    {
        ShowItem(Item);
    }
}
