using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReinforcedBat : Items
{
    bool CanMake = false;
    public static int cnt = 0;

    private void Update()
    {
        Material_List(ItemType.Weapon, "강화 배트", "**장전필요없음**\t\t데미지 : 45\n공격속도 : 0.5\t\t최대 사정거리 : 1m", cnt);
        if (Bat.cnt > 0 && Glass.cnt > 0 && Glue.cnt > 0 && cnt == 0)
        {
            CanMake = true;
            EmphasisSquare.SetActive(true);
        }
        else if (Bat.cnt == 0 || Glass.cnt == 0 || Glue.cnt == 0)
        {
            CanMake = false;
            EmphasisSquare.SetActive(false);
        }
    }

    public void MakeSign()
    {
        UpgradeWeaponMakeSign(1, CanMake, cnt);
    }
}
