using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    enum SceneType : int
    {
        BetaVer = 0
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
