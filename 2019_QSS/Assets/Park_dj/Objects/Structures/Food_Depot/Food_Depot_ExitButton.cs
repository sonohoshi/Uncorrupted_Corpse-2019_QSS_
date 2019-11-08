using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food_Depot_ExitButton : MonoBehaviour
{
    public GameObject FoodDepot_Interection;
    public void FoodDepotUISetActive()
    {
        Food_Depot.FoodDepotOnOff = false;
        FoodDepot_Interection.SetActive(false);
    }
}
