using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wire : Items
{
    public static int cnt = 0;
    private void Update()
    {
        Material_List(ItemType.Material, "와이어", "와이어 + 쇠뇌 = 강화 쇠뇌\n와이어 + 쇠뇌 + 방사능X = 붕괴 쇠뇌", cnt);
    }
}
