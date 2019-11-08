using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyCartridge : Items
{
    public static int cnt = 0;
    private void Update()
    {
        Material_List(ItemType.Material, "빈 탄창", "*영구지속*\n빈 탄창 + (은)탄환 = 탄창", cnt);
    }
}
