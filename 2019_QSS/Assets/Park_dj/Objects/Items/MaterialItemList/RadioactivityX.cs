using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioactivityX : Items
{
    public static int cnt = 0;
    private void Update()
    {
        Material_List(ItemType.Material, "방사능X", "방사능X + 레이저 포인터 + 근접 공격 무기= 광선검,\t\t방사능X + 레이저 포인터 + 돌격소총 = 레이저 돌격소총\n방사능X + 레이저 포인터 + 권총 = 레이저 권총,\t\t방사능X + 와이어 + 쇠뇌 = 붕괴 쇠뇌\n방사능X + 은 + 산탄총 = 붕괴 산탄총", cnt);
    }
}
