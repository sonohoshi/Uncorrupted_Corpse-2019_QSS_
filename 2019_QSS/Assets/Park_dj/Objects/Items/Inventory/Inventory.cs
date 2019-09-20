using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    //나중에 효과음 넣기 클릭할 때 하얀색 테두리로 강조하기


    public static int TabType = 1;

    public GameObject MaterialGridslot;
    public GameObject WeaponGridslot;
    public GameObject OneTimeWeaponGridslot;
    public GameObject ArmorGridslot;
    
    public void ShowItem()
    {
        switch (TabType)
        {
            case 1:
                MaterialGridslot.SetActive(true);
                WeaponGridslot.SetActive(false);
                OneTimeWeaponGridslot.SetActive(false);
                ArmorGridslot.SetActive(false);
                break;
            case 2:
                MaterialGridslot.SetActive(false);
                WeaponGridslot.SetActive(true);
                OneTimeWeaponGridslot.SetActive(false);
                ArmorGridslot.SetActive(false);
                break;
            case 3:
                MaterialGridslot.SetActive(false);
                WeaponGridslot.SetActive(false);
                OneTimeWeaponGridslot.SetActive(true);
                ArmorGridslot.SetActive(false);
                break;
            case 4:
                MaterialGridslot.SetActive(false);
                WeaponGridslot.SetActive(false);
                OneTimeWeaponGridslot.SetActive(false);
                ArmorGridslot.SetActive(true);
                break;
        }
    } 

    private void Update()
    {
        if (PressButton.press == true)
        {
            ShowItem();

        }
        else if (PressButton.press == false)
        {
            TabType = 1;
        }
    }
}
