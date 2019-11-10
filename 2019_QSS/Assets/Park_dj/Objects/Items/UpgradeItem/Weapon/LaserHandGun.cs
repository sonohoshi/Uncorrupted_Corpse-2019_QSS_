using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserHandGun : Items
{
    bool CanMake = false;
    public static int cnt = 0;

    private void Update()
    {
        Material_List(ItemType.Weapon, "레이저 권총", "데미지 : 8\t\t공격속도 : 0.25\n최대 사정거리 : 10m\n탄환이 좀비를 관통합니다.", cnt);
        if (Handgun.cnt > 0 && LaserPointer.cnt > 0 && RadioactivityX.cnt > 0 && cnt == 0)
        {
            CanMake = true;
            EmphasisSquare.SetActive(true);
        }
        else if (Handgun.cnt == 0 || LaserPointer.cnt == 0 || RadioactivityX.cnt == 0 || cnt > 0)
        {
            CanMake = false;
            EmphasisSquare.SetActive(false);
        }
    }

    public void MakeSign()
    {
        UpgradeWeaponMakeSign(6, CanMake, cnt);
    }
}
