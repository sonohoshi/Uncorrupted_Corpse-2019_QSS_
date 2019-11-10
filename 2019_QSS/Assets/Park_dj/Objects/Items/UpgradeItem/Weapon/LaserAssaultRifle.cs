using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserAssaultRifle : Items
{
    bool CanMake = false;
    public static int cnt = 0;

    private void Update()
    {
        Material_List(ItemType.Weapon, "레이저 돌격 소총", "최대 장전수 : 20\t\t데미지 : 10\t\t공격속도 : 4\n최대 사정거리 : 15m\n탄환이 좀비를 관통합니다.", cnt);
        if (AssaultRifle.cnt > 0 && LaserPointer.cnt > 0 && RadioactivityX.cnt > 0 && cnt == 0)
        {
            CanMake = true;
            EmphasisSquare.SetActive(true);
        }
        else if (AssaultRifle.cnt == 0 || LaserPointer.cnt == 0 || RadioactivityX.cnt == 0 || cnt > 0)
        {
            CanMake = false;
            EmphasisSquare.SetActive(false);
        }
    }

    public void MakeSign()
    {
        UpgradeWeaponMakeSign(5, CanMake, cnt);
    }
}
