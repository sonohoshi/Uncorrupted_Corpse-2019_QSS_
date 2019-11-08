using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring : Items
{
    public static int cnt = 0;
    private void Update()
    {
        Material_List(ItemType.Material, "스프링", "스프링 + 총 = 해당 총 데미지 증가", cnt);
    }
}
