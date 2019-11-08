using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Branch : Items
{
    public static int cnt = 0;
    private void Update()
    {
        Material_List(ItemType.Material, "나뭇가지", "나뭇가지 + 고철 = 볼트\n나뭇가지 + 은 = 은 볼트", cnt);
    }
}
