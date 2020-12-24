using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CancelButton : MonoBehaviour
{
    public GameObject PutDescription;
    public GameObject UIOnOffButton;
    public void ClickUIOnOffButton()
    {
        InstallTurret selectTurret = GameObject.Find("AfterSelect").GetComponent<InstallTurret>();
        //select스크립트에있는 Turret과 installDealy초기화
        PutDescription.SetActive(false);
        UIOnOffButton.SetActive(true);
        selectTurret.Turret = 0;
        selectTurret.installDelay = 0;
        gameObject.SetActive(false);
    }
}
