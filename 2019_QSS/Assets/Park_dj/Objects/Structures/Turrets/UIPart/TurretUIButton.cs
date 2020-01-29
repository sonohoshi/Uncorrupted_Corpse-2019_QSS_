using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretUIButton : MonoBehaviour
{
    public GameObject TurretUI;
    public void OnOffTurretUI()
    {
        InstallTurret selectTurret = GameObject.Find("AfterSelect").GetComponent<InstallTurret>();
        selectTurret.Turret= 0;//선택한 터렛 초기화
        TurretUI.SetActive(!TurretUI.activeSelf);
    }
}
