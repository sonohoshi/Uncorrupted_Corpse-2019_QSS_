using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food_Depot : Structures
{
    public GameObject F_D_Interection;
    public static bool interaction = false;
    public static int food = 1000;
    public static bool FoodDepotOnOff = false;

    private void Start()
    {   
        Begin();
        HP = 2000;
        F_D_Interection.SetActive(false);
    }

    private void OnMouseUp()
    {
        if (interaction == false && CraftingTable.OnOffTable == false && PressButton.press == false)
        {
            FoodDepotOnOff = true;
            F_D_Interection.SetActive(true);
            NowFood_Health.problem = 0;
        }
    }
}
