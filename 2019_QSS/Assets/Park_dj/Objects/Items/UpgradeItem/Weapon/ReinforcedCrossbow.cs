using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReinforcedCrossbow : Items
{
    bool CanMake = false;
    public static int cnt = 0;
    private void Update()
    {
        Material_List(ItemType.Weapon, "강화 쇠뇌", "최대 장전수 : 1\t\t데미지 : 60\n공격속도 : 1\t\t최대 사정거리 : 15m", cnt);
        if (Crossbow.cnt > 0 && Wire.cnt > 0 && Glue.cnt > 0 && cnt == 0)
        {
            CanMake = true;
            EmphasisSquare.SetActive(true);
        }
        else if (Crossbow.cnt == 0 || Wire.cnt == 0 || Glue.cnt == 0 || cnt > 0)
        {
            CanMake = false;
            EmphasisSquare.SetActive(false);
        }
    }

    public void MakeSign()
    {
        UpgradeWeaponMakeSign(3, CanMake, cnt);
    }
}
