using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssaultRifle : Items
{
    public static int cnt = 0;
    private void Update()
    {
        Material_List(ItemType.Weapon, "돌격소총", "최대 장전수 : 20\t\t데미지 : 10\n공격속도 : 0.2\t\t최대 사정거리 : 15m", cnt);
    }
}
