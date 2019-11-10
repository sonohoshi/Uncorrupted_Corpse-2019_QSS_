using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clothes : Items
{
    bool CanMake = false;
    public static int cnt = 0;

    private void Update()
    {
        Material_List(ItemType.Armor, "옷", "방어력을 3 얻습니다.\n같은 종류의 방어구는 두 개 이상 가질 수 없습니다.", cnt);
        if (Fabric.cnt > 0 && Thread.cnt > 0 && cnt == 0)
        {
            CanMake = true;
            EmphasisSquare.SetActive(true);
        }
        else if (Fabric.cnt == 0 || Thread.cnt == 0 || cnt > 0)
        {
            CanMake = false;
            EmphasisSquare.SetActive(false);
        }
    }

    public void MakeSign()
    {
        ArmorMakeSign(1, CanMake, cnt);
    }
}
