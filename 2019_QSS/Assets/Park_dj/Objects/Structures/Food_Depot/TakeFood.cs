using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TakeFood : MonoBehaviour
{
    public InputField InputField;
    int Now_HealthPoint;
    Player plr;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            if(Food_Depot.food - int.Parse(InputField.text) < 0)
            {
                NowFood_Health.problem = 1;
                InputField.text = "\0";
            }       
            else if(plr.GetStats()[0] + int.Parse(InputField.text) * 3 > 500)
            {
                NowFood_Health.problem = 2;
                InputField.text = "\0";
            }   
            else
            {
                NowFood_Health.problem = 0;
                Food_Depot.food -= int.Parse(InputField.text);
                /*player.PlusHealth(int.Parse(InputField.text) * 3);*/
                InputField.text = "\0";
            }
        }
    }
}
