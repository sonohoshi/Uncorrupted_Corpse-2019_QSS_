using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fabric : Items
{
    public static int cnt = 0;
    private void Update()
    {
        Material_List(ItemType.Material, "천", "천 + 실 = 옷", cnt);
    }
}
