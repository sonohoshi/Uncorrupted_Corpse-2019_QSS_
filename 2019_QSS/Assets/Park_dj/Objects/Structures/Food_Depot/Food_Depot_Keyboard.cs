using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food_Depot_Keyboard : MonoBehaviour
{
    public void ChangeButton()
    {
        TakeFood.OKSign = true;        
    }

    public void PressNumber1()
    {
        TakeFood._TakeFood = 1;
    }

    public void PressNumber2()
    {
        TakeFood._TakeFood = 2;
    }

    public void PressNumber3()
    {
        TakeFood._TakeFood = 3;
    }

    public void PressNumber4()
    {
        TakeFood._TakeFood = 4;
    }

    public void PressNumber5()
    {
        TakeFood._TakeFood = 5;
    }

    public void PressNumber6()
    {
        TakeFood._TakeFood = 6;
    }

    public void PressNumber7()
    {
        TakeFood._TakeFood = 7;
    }

    public void PressNumber8()
    {
        TakeFood._TakeFood = 8;
    }

    public void PressNumber9()
    {
        TakeFood._TakeFood = 9;
    }

    public void PressNumber10()
    {
        TakeFood._TakeFood += 10;
    }

    public void PressNumber50()
    {
        TakeFood._TakeFood += 50;
    }

}
