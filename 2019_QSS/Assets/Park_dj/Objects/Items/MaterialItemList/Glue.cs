using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glue : Items
{
    public static int cnt = 0;
    private void Update()
    {
        Material_List(ItemType.material, Material.Glue, "접착제", "접착제 + 쇠뇌 + 와이어 = 강화 쇠뇌\n접착제 + 방망이 + 못 = 강화 방망이", cnt);
    }
}
