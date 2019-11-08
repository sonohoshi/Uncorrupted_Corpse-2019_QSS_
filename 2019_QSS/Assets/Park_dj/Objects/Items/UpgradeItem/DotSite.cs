using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotSite : Items
{
    bool CanMake = false;
    public static int cnt = 0;

    private void Start()
    {
        
    }

    private void Update()
    {
        Material_List(ItemType.OneTimeWeapon, "도트 사이드", "사용시 장착하고 있는 총기에 부착되어 데미지가 x만큼 증가합니다.", cnt);
        if (LaserPointer.cnt > 0 && Glass.cnt > 0)
        {
            CanMake = true;
            EmphasisSquare.SetActive(true);
        }
        else if (LaserPointer.cnt == 0 || Glass.cnt == 0)
        {
            CanMake = false;
            EmphasisSquare.SetActive(false);
        }
    }

    public void MakeSign()
    {
        OneTimeWeaponMakeSign(8, CanMake);
    }
}
