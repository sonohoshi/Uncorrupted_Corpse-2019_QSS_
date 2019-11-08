using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameBottle : Items
{
    bool CanMake = false;
    public static int cnt = 0;

    private void Update()
    {
        Material_List(ItemType.OneTimeWeapon, "화염병", "사용시 초당 15의 대미지로 광역 피해를\n입히는 화염병을 던집니다.\n화염 지속시간은 5초 입니다.", cnt);
        if (Lighter.cnt > 0 && Glass.cnt > 0)
        {
            CanMake = true;
            EmphasisSquare.SetActive(true);
        }
        else if (Gunpowder.cnt == 0 || Glass.cnt == 0)
        {
            CanMake = false;
            EmphasisSquare.SetActive(false);
        }
    }

    public void MakeSign()
    {
        OneTimeWeaponMakeSign(7, CanMake);
    }
}
