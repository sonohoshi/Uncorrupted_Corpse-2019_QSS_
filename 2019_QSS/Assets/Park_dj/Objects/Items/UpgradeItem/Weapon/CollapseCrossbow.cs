using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollapseCrossbow : Items
{
    bool CanMake = false;
    public static int cnt = 0;

    private void Update()
    {
        Material_List(ItemType.Weapon, "붕괴 쇠뇌", "최대 장전수 : 1\t\t데미지 : 50\t\t공격속도 : 1\n최대 사정거리 : 15m\n피격시 피격당한 상대는 초당 방어력을 무시한 5의 피해를 5초간 받습니다.", cnt);
        if (Crossbow.cnt > 0 && Wire.cnt > 0 && RadioactivityX.cnt > 0 && cnt == 0)
        {
            CanMake = true;
            EmphasisSquare.SetActive(true);
        }
        else if (Crossbow.cnt == 0 || Wire.cnt == 0 || RadioactivityX.cnt == 0 || cnt > 0)
        {
            CanMake = false;
            EmphasisSquare.SetActive(false);
        }
    }

    public void MakeSign()
    {
        UpgradeWeaponMakeSign(4, CanMake, cnt);
    }
}
