using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : Items
{
    public static int cnt = 0;

    private void Update()
    {
        Material_List(ItemType.Weapon, "샷건", "최대 장전수 : 5\t\t데미지 : 50\n공격속도 : 1\t\t최대 사정거리 : 5m", cnt);
    }
}
