using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Items : MonoBehaviour
{
    public string ItemName;
    public string ItemCombination;
    public int ItemCNT;
    public Material MaterialName;
    public ItemType Itemtype;
    public Sprite ItemIcon;

    protected void Upgrade()
    {

    }

    public enum ItemType
    {
        material,
        OneTimeWeapon,
        Armor,
        Weapon
    }

    public enum Material
    {
        ScrapMetal, 
        Gunpowder,
        Glass,
        Glue,
        Spring,
        Wire,
        EmptyCartridge,
        Branch,
        Nail,
        Lighter,
        Fabric,
        Thread,
        Silver,
        LaserPointer,
        RadioactivityX,
    }

    public void Material_List(ItemType Item_Type, Material material_Name, string Item_Name, string Item_Combination, int Item_CNT)
    {
        ItemCNT = Item_CNT;
        Itemtype = Item_Type;
        ItemName = Item_Name;
        MaterialName = material_Name;
        ItemCombination = Item_Combination;
        ItemIcon = Resources.Load("ItemIcon/" + material_Name.ToString(), typeof(Sprite)) as Sprite;
    }
}
    