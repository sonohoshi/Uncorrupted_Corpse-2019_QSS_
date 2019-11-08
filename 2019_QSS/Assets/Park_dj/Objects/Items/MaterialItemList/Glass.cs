using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glass : Items
{
    public static int cnt = 0;
    private void Update()
    {
        Material_List(ItemType.Material, "유리", "유리 + 화약X2 = 파편지뢰,\t\t유리 + 레이저 포인터 = 도트 사이트\n유리 + 라이터 = 화염병", cnt);
    }
}
