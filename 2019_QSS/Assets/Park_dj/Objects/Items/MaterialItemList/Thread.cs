using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thread : Items
{
    public static int cnt = 0;
    private void Update()
    {
        Material_List(ItemType.Material, "실", "실 + 천 = 옷", cnt);
    }
}
