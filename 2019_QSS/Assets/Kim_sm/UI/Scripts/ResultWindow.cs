using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ResultWindow : MonoBehaviour
{
    public TextMeshProUGUI resultTMP;
    public TextMeshProUGUI leftWaveTMP;

    private static int deadZombies;

    private void SetResult(bool isDead)
    {
        resultTMP.text = isDead ? "당신은 죽었습니다..." : "더 이상 남은 좀비가 없는 것 같다...";
        leftWaveTMP.text += isDead ? ZombieSpawner.wave.ToString() + " / 10" : "그런건 없다!";
    }

    private void ShowResult()
    {
        this.gameObject.SetActive(true);
    }

    public void GameEnd(bool isDead)
    {
        SetResult(isDead);
        Time.timeScale = 0f;
        ShowResult();
    }
}
