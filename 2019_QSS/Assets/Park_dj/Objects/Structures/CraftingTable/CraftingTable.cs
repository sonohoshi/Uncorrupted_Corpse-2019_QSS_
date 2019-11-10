using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CraftingTable : MonoBehaviour
{
    public static int TabType = 1;
    public static bool OnOffTable = false;
    //분류 버튼
    public GameObject WeaponGridslot;
    public GameObject OneTimeWeaponGridslot;
    public GameObject ArmorGridslot;
    //식량 창고
    public GameObject C_T_Interection;
    public void ShowItem()
    {
        switch (TabType)
        {
            case 1:
                WeaponGridslot.SetActive(true);
                OneTimeWeaponGridslot.SetActive(false);
                ArmorGridslot.SetActive(false);
                break;
            case 2:
                WeaponGridslot.SetActive(false);
                OneTimeWeaponGridslot.SetActive(true);
                ArmorGridslot.SetActive(false);
                break;
            case 3:
                WeaponGridslot.SetActive(false);
                OneTimeWeaponGridslot.SetActive(false);
                ArmorGridslot.SetActive(true);
                break;
        }
    }

    private void Start()
    {
        C_T_Interection.SetActive(false);
    }


    private void Update()
    {        
        if(OnOffTable == true)
        {
            ShowItem();
        }
        else if(OnOffTable == false)
        {
            TabType = 1;
        }
    }


    //버튼
    private void OnMouseUp()
    {
        if (PressButton.press == false && Food_Depot.FoodDepotOnOff == false)
        {
            C_T_Interection.SetActive(true);
            OnOffTable = true;
            MakeItemButton.CanMakeOnetimeWeaponItem = 0;
            MakeItemButton.ClickOnetimeWeaponItem = 0;
        }
    }
}
