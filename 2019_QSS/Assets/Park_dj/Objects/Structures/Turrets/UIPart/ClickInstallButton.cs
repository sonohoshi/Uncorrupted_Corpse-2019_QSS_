using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickInstallButton : MonoBehaviour
{
    public GameObject TurretUI;
    public GameObject PutDescription;
    public GameObject CancelButton;
    public GameObject UIOnOffButton;
    //첫번째 터렛
    public void ClickFirstTurret()
    {
        InstallTurret selectTurret = GameObject.Find("AfterSelect").GetComponent<InstallTurret>();
        PutDescription.SetActive(true);
        CancelButton.SetActive(true);
        selectTurret.Turret = 1;
        UIOnOffButton.SetActive(false);
        TurretUI.SetActive(false);
    }
    //두번째 터렛
    public void ClickSecondTurret()
    {
        InstallTurret selectTurret = GameObject.Find("AfterSelect").GetComponent<InstallTurret>();
        PutDescription.SetActive(true);
        CancelButton.SetActive(true);
        selectTurret.Turret = 2;
        UIOnOffButton.SetActive(false);
        TurretUI.SetActive(false);
    }
    //세번째 터렛
    public void ClickThirdTurret()
    {
        InstallTurret selectTurret = GameObject.Find("AfterSelect").GetComponent<InstallTurret>();
        PutDescription.SetActive(true);
        CancelButton.SetActive(true);
        selectTurret.Turret = 3;
        UIOnOffButton.SetActive(false);
        TurretUI.SetActive(false);
    }
}
