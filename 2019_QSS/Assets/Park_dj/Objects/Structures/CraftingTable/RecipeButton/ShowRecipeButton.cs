using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowRecipeButton : MonoBehaviour
{
    public GameObject RecipeUI;

    public static bool isOnOff = false;
    public void ShowRecipeUI()
    {
        if ((MakeItemButton.ClickUpgradeWeapon != 0 || 
            MakeItemButton.ClickOnetimeWeaponItem != 0 ||
            MakeItemButton.ClickArmor != 0) && 
            MakeItemButton.ErrorMessageUIisOnOff == false)
        {
            isOnOff = true;
            RecipeUI.SetActive(true);
        }
    }
}
