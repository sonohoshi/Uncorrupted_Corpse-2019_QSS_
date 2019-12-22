using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public GameObject selectUI;
    public GameObject localUI;
    public GameObject serverUI;
    
    enum SceneType : int
    {
        BetaVer = 0
    }

    public void UiChange()
    {
        localUI.SetActive(false);
        serverUI.SetActive(false);
        selectUI.SetActive(true);
    }
    
    public void GameStart()
    {
        SceneChange("BetaVer");
    }

    public void GameQuit()
    {
        Application.Quit();
    }

    private void SceneChange(string name)
    {
        SceneManager.LoadScene(name);
    }
}
