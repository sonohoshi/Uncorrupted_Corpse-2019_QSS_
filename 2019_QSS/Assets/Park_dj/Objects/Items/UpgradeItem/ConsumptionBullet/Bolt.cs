﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolt :Items
{
    bool CanMake = false;
    
    public static int cnt = 0;

    private void Update()
    {
        Material_List(ItemType.ConsumptionBullet, "볼트", "이 아이템은 쇠뇌를 사용한다면 재장전할 때 사용됩니다.", cnt);

        if (ScrapMetal.cnt > 0 && Branch.cnt > 0)
        {
            CanMake = true;
            EmphasisSquare.SetActive(true);
        }
        else if (ScrapMetal.cnt == 0 || Branch.cnt == 0)
        {
            CanMake = false;
            EmphasisSquare.SetActive(false);
        }
    }
    public void MakeSign()
    {
        OneTimeWeaponMakeSign(3, CanMake);
    }
}