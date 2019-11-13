using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TakeFood : MonoBehaviour
{
    public Player plr;
    public Text TakeFoodCntText;
    int Now_HealthPoint;
    public static bool OKSign = false;
    public static int _TakeFood = 0;
    void Update()
    {
        TakeFoodCntText.text = _TakeFood.ToString();
        if (OKSign)
        {
            if (Food_Depot.food - _TakeFood < 0)
            {
                NowFood_Health.problem = 1;
            }
            /*else if (plr.GetStats()[0] + _TakeFood * 3 > 500)
                InputField.text = "\0";
            else if (plr.GetStats()[0] + int.Parse(InputField.text) * 3 > 500)
            {
                NowFood_Health.problem = 2;
            }*/
            else
            {
                NowFood_Health.problem = 0;
                plr.PlusHealth(_TakeFood * 3);
                Food_Depot.food -= _TakeFood;
            }
            _TakeFood = 0;
            OKSign = false;
        }
    }
    
}
