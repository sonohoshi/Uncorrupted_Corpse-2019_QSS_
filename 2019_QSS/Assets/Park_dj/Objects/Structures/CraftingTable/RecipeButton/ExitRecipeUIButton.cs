using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitRecipeUIButton : MonoBehaviour
{
    public GameObject RecipeUI;
    public void ExitRecipeUI()
    {
        ShowRecipeButton.isOnOff = false;
        RecipeUI.SetActive(false);
    }
}
