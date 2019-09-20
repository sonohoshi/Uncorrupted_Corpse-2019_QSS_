using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighter : Items
{
    public static int cnt = 0;
    private void Update()
    {
        Material_List(ItemType.material, Material.Lighter, "라이터", "라이터 + 유리 = 화염병", cnt);
    }
}
