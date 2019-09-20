using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrapMetal : Items
{
    public static int cnt = 0;
    private void Update()
    {
        Material_List(ItemType.material, Material.ScrapMetal, "고철", "고철 + 옷 = 갑옷\n고철 + 화약 = 탄환\n고철 + 화약X2 = 수류탄\n고철 + 나뭇가지 = 화살 또는 볼트", cnt);
    }
}
