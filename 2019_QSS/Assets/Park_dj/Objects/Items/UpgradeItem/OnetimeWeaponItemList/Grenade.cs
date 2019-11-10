using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : Items
{
    bool CanMake = false;
    public static int cnt = 0;

    private void Update()
    {
        Material_List(ItemType.OneTimeWeapon, "수류탄", "사용시 200의 대미지로 광역 피해를\n입히는 수류탄을 던집니다.", cnt);
        if (Gunpowder.cnt > 1 && ScrapMetal.cnt > 0)
        {
            CanMake = true;
            EmphasisSquare.SetActive(true);
        }
        else if (Gunpowder.cnt <= 1 || ScrapMetal.cnt == 0)
        {
            CanMake = false;
            EmphasisSquare.SetActive(false);
        }
    }

    public void MakeSign()
    {
        OneTimeWeaponMakeSign(5, CanMake);
    }
}
