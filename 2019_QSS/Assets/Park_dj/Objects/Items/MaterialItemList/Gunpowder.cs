using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunpowder : Items
{
    public static int cnt = 0;
    private void Update()
    {
        Material_List(ItemType.material, Material.Gunpowder, "화약", "화약 + 고철 = 탄환\n화약X2 + 고철 = 수류탄\n화약*2 + 유리 = 파편지뢰\n화약 + 은 = 은탄환\n", cnt);
    }
}
