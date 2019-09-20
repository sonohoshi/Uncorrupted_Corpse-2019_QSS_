using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingTable : MonoBehaviour
{
    public GameObject C_T_Interection;
    private void Start()
    {
        C_T_Interection.SetActive(false);
    }
    private void OnMouseUp()
    {
        if(PressButton.press == false) C_T_Interection.SetActive(true);
    }
}
