using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrapMetal : Items
{
    public static int cnt = 1;
    private void Update()
    {
        Material_List(ItemType.Material, "고철", "고철 + 옷 = 갑옷,\t\t고철 + 화약 = 탄환\n고철 + 화약X2 = 수류탄,\t\t고철 + 나뭇가지 = 볼트", cnt);
    }
}
