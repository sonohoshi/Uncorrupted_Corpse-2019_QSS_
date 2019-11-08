using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armor : Items
{
    bool CanMake = false;
    public static int cnt = 0;

    private void Update()
    {
        Material_List(ItemType.Armor, "갑옷", "방어력을 5 얻습니다.\n같은 종류의 방어구는 두 개 이상 가질 수 없습니다.", cnt);
        if (Clothes.cnt > 0 && ScrapMetal.cnt > 0 && cnt == 0)
        {
            CanMake = true;
            EmphasisSquare.SetActive(true);
        }
        else if (Clothes.cnt == 0 || ScrapMetal.cnt == 0 || cnt > 0)
        {
            CanMake = false;
            EmphasisSquare.SetActive(false);
        }
    }

    public void MakeSign()
    {
        ArmorMakeSign(2, CanMake, cnt);
    }
}
