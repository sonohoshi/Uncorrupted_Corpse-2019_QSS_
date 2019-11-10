using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat : Items
{
    public static int cnt = 1;
    private void Update()
    {
        Material_List(ItemType.Weapon, "배트", "**장전필요없음**\t\t데미지 : 30\n공격속도 : 0.5\t\t최대 사정거리 : 1m", cnt);
    }
}
