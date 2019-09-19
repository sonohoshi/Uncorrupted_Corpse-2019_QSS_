using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nail : Items
{
    public static int cnt = 0;
    private void Update()
    {
        Material_List(ItemType.material, Material.Nail, "못", "못 + 배트 + 접착제 = 강화 배트", cnt);
    }
}
