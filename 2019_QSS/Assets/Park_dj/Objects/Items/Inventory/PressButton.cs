using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PressButton : MonoBehaviour
{
    public GameObject InventoryUI;
    public Text itemName_Text;
    public Text itemCnt_Text;
    public Text Item_Description;


    public static bool press = false;
    private void Awake()
    {
        InventoryUI.SetActive(false);
    }
    public void InventoryUISetActive()
    {
        if(press == true)
        {
            itemName_Text.text = "";
            itemCnt_Text.text = "";
            Item_Description.text = "";
            press = false;
        }
        else if(press == false)
        {
            press = true;
            itemName_Text.text = "";
            itemCnt_Text.text = "";
            Item_Description.text = "무기, 갑옷, 탄약, 구조물을 만들 때 사용하는 재료입니다.";
        }
        InventoryUI.SetActive(!InventoryUI.activeSelf);
    }
}
