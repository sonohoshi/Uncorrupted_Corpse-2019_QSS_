using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NowFood_Health : MonoBehaviour
{
    string Food;
    string Health;
    public Text TextObject;
    public Player plr;
    static public int problem = 0;
    void Update()
    {
        string Food = Food_Depot.food.ToString();
        string Health = plr.GetStats()[0].ToString();
        if (problem == 0)
        {
            TextObject.text = "현재 가지고 있는 식량 : " + Food + "\n"
                          + "현재 당신의 체력 : " + Health + "\n"
                          + "식량과 체력의 변환 비 -> 1 : 3";
        }
        else if(problem == 1)
        {
            TextObject.text = "*식량이 부족합니다.*\n"
                 + "현재 가지고 있는 식량 : " + Food + "\n"
                 + "현재 당신의 체력 : " + Health + "\n"
                 + "식량과 체력의 변환 비 -> 1 : 3";
        }
        else if (problem == 2)
        {
            TextObject.text = "*체력이 500을 초과합니다.*\n"
                          + "현재 가지고 있는 식량 : " + Food + "\n"
                          + "현재 당신의 체력 : " + Health + "\n"
                          + "식량과 체력의 변환 비 -> 1 : 3"; 
        }
    }
}