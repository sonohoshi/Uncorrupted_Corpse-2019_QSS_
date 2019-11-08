using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Silver : Items
{
    public static int cnt = 0;
    private void Update()
    {
        Material_List(ItemType.Material, "은", "은 + 나뭇가지 = 은 볼트\n은 + 산탄총 + 방사능X = 붕괴 산탄총,\t\t은 + 화약 = 은탄환", cnt);
    }
}
    