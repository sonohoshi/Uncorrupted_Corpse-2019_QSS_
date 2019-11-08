using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollapseShotGun : Items
{
    bool CanMake = false;
    public static int cnt = 0;

    private void Update()
    {
        Material_List(ItemType.Weapon, "붕괴 산탄총", "최대 장전수 : 5\t\t데미지 : 50\n공격속도 : 1\t\t최대 사정거리 : 5m\n피격시 피격당한 상대는 초당 방어력을 무시한 5의 피해를 5초간 받습니다.", cnt);
        if (Shotgun.cnt > 0 && Silver.cnt > 0 && RadioactivityX.cnt > 0 && cnt == 0)
        {
            CanMake = true;
            EmphasisSquare.SetActive(true);
        }
        else if (Shotgun.cnt == 0 || Silver.cnt == 0 || RadioactivityX.cnt == 0 || cnt > 0)
        {
            CanMake = false;
            EmphasisSquare.SetActive(false);
        }
    }

    public void MakeSign()
    {
        UpgradeWeaponMakeSign(7, CanMake, cnt);
    }
}
