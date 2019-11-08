using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CraftingTableButton : MonoBehaviour
{
    public GameObject C_T_Interection;
    public Text itemName_Text;
    public Text itemDescription;
    public Text itemCnt_Text;
    public void CraftingTableUISetActive()
    {
        if(ShowRecipeButton.isOnOff == false && MakeItemButton.ErrorMessageUIisOnOff == false)
        {
            C_T_Interection.SetActive(false);
            CraftingTable.OnOffTable = false;
            itemName_Text.text = "";
            itemDescription.text = "좀비를 죽일 때 사용하는 장착형 무기를 제작합니다.";
            itemCnt_Text.text = "";
        }
    }
}
