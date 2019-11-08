using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food_Depot : Structures
{
    private GameObject F_D_Interection;
    public static bool interaction = false;
    public static int food = 1000;

    private void Start()
    {   
        Begin(2000, 10, 0, 0);
    }
        
    void Update()
    {
        if(interaction == true)
        {
          //  F_D_Interection.SetActive(true);
        }
        else if(interaction == false)
        {
           // F_D_Interection.SetActive(false);
        }
    }       


}
