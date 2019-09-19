using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingTableButton : MonoBehaviour
{
    public GameObject C_T_Interection;
    public void CraftingTableUISetActive()
    {
        C_T_Interection.SetActive(false);
    }
}
