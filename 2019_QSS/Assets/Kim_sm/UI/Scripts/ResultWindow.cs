using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultWindow : MonoBehaviour
{
    public Transform windowIMG;
    public Button returnBack;
    
    private Text result;

    private static int deadZombies;

    public static void DeadZombie() => deadZombies++;

    public void SelectResult()
    {
        if (ZombieSpawner.wave <= 10)
        {
            result.text = "당신은 죽었습니다...";
        }
        else
        {
            result.text = "더 이상 남은 좀비가 없는 것 같다...";
        }
    }

    public void ShowResult()
    {
        
    }
}
