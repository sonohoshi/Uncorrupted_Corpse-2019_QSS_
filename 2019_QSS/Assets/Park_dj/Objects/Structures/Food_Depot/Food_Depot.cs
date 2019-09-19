using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food_Depot : Structures
{
    public GameObject F_D_Interection;
    public static bool interaction = false;
    public static int food = 1000;

    private void Start()
    {   
        begin();
        HP = 2000;    
    }
        
    void Update()
    {
        if(interaction == true)
        {
            F_D_Interection.SetActive(true);
        }
        else if(interaction == false)
        {
            F_D_Interection.SetActive(false);
        }
    }       
}
