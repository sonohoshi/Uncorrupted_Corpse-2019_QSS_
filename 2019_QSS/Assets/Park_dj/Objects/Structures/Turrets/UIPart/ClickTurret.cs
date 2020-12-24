using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickTurret : MonoBehaviour
{
    public Text DescriptionText;
    //터렛 설명
    public void ClickFirstTurret()
    {
        DescriptionText.text = "체력 : 25\t공격력:x\n0.5초 간격으로 계속 일반 탄환을 발사  ";
    }
    public void ClickSecondTurret()
    {
        DescriptionText.text = "";
    }
    public void ClickThirdTurret()
    {
        DescriptionText.text = "";
    }
}
