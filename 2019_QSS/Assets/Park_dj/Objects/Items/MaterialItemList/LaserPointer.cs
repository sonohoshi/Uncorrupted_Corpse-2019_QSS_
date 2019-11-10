using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserPointer : Items
{
    public static int cnt = 0;
    private void Update()
    {
        Material_List(ItemType.Material, "레이저 포인터", "\t레이저 포인터 + 근접 공격 무기 + 방사능X = 광선검,\t\t레이저 포인터 + 돌격소총 + 방사능X = 레이저 돌격소총\n레이저 포인터 + 권총 + 방사능X = 레이저 권총,\t\t레이저 포인터 + 유리 = 도트 사이트", cnt);
    }
}
