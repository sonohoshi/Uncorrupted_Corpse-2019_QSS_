using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FragmentMine : Items
{
    bool CanMake = false;
    public static int cnt = 0;

    private void Update()
    {
        Material_List(ItemType.OneTimeWeapon, "파편 지뢰", "사용시 200의 대미지로 광역 피해를\n입히는 지뢰를 설치합니다.", cnt);
        if (Gunpowder.cnt > 1 && Glass.cnt > 0)
        {
            CanMake = true;
            EmphasisSquare.SetActive(true);
        }
        else if (Gunpowder.cnt <= 1 || Glass.cnt == 0)
        {
            CanMake = false;
            EmphasisSquare.SetActive(false);
        }
    }

    public void MakeSign()
    {
        OneTimeWeaponMakeSign(6, CanMake);
    }
}
