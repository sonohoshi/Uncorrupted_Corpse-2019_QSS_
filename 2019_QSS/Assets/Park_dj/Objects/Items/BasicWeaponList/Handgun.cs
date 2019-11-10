using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handgun : Items
{
    public static int cnt = 0;

    private void Update()
    {
        Material_List(ItemType.Weapon, "권총", "최대 장전수 : 8\t\t데미지 : 10\n공격속도 : 0.25\t\t최대 사정거리 : 10m", cnt);
    }
}
