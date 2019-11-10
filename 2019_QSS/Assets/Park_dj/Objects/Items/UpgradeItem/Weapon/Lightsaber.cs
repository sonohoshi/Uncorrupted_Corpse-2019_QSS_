using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightsaber : Items
{
    bool CanMake = false;
    public static int cnt = 0;

    private void Update()
    {
        Material_List(ItemType.Weapon, "광선검", "**장전필요없음**\t\t데미지 : 30\n공격속도 : 1\t\t최대 사정거리 : 1m", cnt);
        if (Bat.cnt > 0 && LaserPointer.cnt > 0 && RadioactivityX.cnt > 0 && cnt == 0)
        {
            CanMake = true;
            EmphasisSquare.SetActive(true);
        }
        else if (Bat.cnt == 0 || LaserPointer.cnt == 0 || RadioactivityX.cnt == 0 || cnt > 0)
        {
            CanMake = false;
            EmphasisSquare.SetActive(false);
        }
    }

    public void MakeSign()
    {
        UpgradeWeaponMakeSign(2, CanMake, cnt);
    }
}
