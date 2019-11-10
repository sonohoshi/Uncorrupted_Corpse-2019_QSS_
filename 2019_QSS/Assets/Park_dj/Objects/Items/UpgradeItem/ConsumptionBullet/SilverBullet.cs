using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SilverBullet : Items
{
    bool CanMake = false;
    public static int cnt = 0;

    private void Update()
    {
        Material_List(ItemType.ConsumptionBullet, "은 탄환", "빈 탄창과 이 아이템은 재장전할 때 합쳐집니다.", cnt);
        if (Gunpowder.cnt > 0 && Silver.cnt > 0)
        {
            CanMake = true;
            EmphasisSquare.SetActive(true);
        }
        else if (Gunpowder.cnt == 0 || Silver.cnt == 0)
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

