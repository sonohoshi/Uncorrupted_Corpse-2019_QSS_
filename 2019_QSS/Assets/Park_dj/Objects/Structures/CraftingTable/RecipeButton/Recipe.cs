using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Recipe : MonoBehaviour
{
    public Text RecipeDescription;
    public Text ItemRecipeName;

    public void Start()
    {
        gameObject.SetActive(false);
    }
    private void Update()   
    {
        if (MakeItemButton.ClickUpgradeWeapon == 0 && MakeItemButton.ClickOnetimeWeaponItem == 0 && MakeItemButton.ClickArmor == 0)
            { RecipeDescription.text = ""; ItemRecipeName.text = ""; gameObject.SetActive(false); }//레시피 초기화
        else if (MakeItemButton.ClickOnetimeWeaponItem != 0)
        {
            if (MakeItemButton.ClickOnetimeWeaponItem == 1)
            { RecipeDescription.text = "화약 + 고철"; ItemRecipeName.text = "탄환"; }
            else if (MakeItemButton.ClickOnetimeWeaponItem == 2)
            { RecipeDescription.text = "화약 + 은"; ItemRecipeName.text = "은 탄환"; }
            else if (MakeItemButton.ClickOnetimeWeaponItem == 3)
            { RecipeDescription.text = "고철 + 나뭇가지"; ItemRecipeName.text = "볼트"; }
            else if (MakeItemButton.ClickOnetimeWeaponItem == 4)
            { RecipeDescription.text = "은 + 나뭇가지"; ItemRecipeName.text = "은 볼트"; }
            else if (MakeItemButton.ClickOnetimeWeaponItem == 5)
            { RecipeDescription.text = "화약X2 + 고철"; ItemRecipeName.text = "수류탄"; }
            else if (MakeItemButton.ClickOnetimeWeaponItem == 6)
            { RecipeDescription.text = "화약X2 + 유리\n"; ItemRecipeName.text = "파편 지뢰"; }
            else if (MakeItemButton.ClickOnetimeWeaponItem == 7)
            { RecipeDescription.text = "라이터 + 유리"; ItemRecipeName.text = "화염병"; }
            else if (MakeItemButton.ClickOnetimeWeaponItem == 8)
            { RecipeDescription.text = "레이저 포인터 +유리"; ItemRecipeName.text = "도트 사이트"; }          
        }//일회용 아이템 레시피
        else if (MakeItemButton.ClickUpgradeWeapon != 0)
        {
            if (MakeItemButton.ClickUpgradeWeapon == 1)
            { RecipeDescription.text = "배트 + 못 + 접착제"; ItemRecipeName.text = "강화 배트"; }
            else if (MakeItemButton.ClickUpgradeWeapon == 2)
            { RecipeDescription.text = "배트 + 레이저 포인터 + 방사능X"; ItemRecipeName.text = "광선검"; }
            else if (MakeItemButton.ClickUpgradeWeapon == 3)
            { RecipeDescription.text = "쇠뇌 + 와이어 + 접착제"; ItemRecipeName.text = "강화 쇠뇌"; }
            else if (MakeItemButton.ClickUpgradeWeapon == 4)
            { RecipeDescription.text = "쇠뇌 + 와이어 + 방사능X"; ItemRecipeName.text = "붕괴 쇠뇌"; }
            else if (MakeItemButton.ClickUpgradeWeapon == 5)
            { RecipeDescription.text = "돌격 소총 + 레이저 포인터 + 방사능X"; ItemRecipeName.text = "레이저 돌격 소총"; }
            else if (MakeItemButton.ClickUpgradeWeapon == 6)
            { RecipeDescription.text = "권총 + 레이저 포인터 + 방사능X"; ItemRecipeName.text = "레이저 권총"; }
            else if (MakeItemButton.ClickUpgradeWeapon == 7)
            { RecipeDescription.text = "산탄총 + 은 + 방사능X"; ItemRecipeName.text = "붕괴 산탄총"; }
        }//업그레이드 무기 레시피
        else if (MakeItemButton.ClickArmor != 0)
        {
            if (MakeItemButton.ClickArmor == 1)
            { RecipeDescription.text = "천 + 실"; ItemRecipeName.text = "옷"; }
            if (MakeItemButton.ClickArmor == 2)
            { RecipeDescription.text = "옷 + 고철"; ItemRecipeName.text = "갑옷"; }
            if (MakeItemButton.ClickArmor == 3)
            { RecipeDescription.text = "옷 + 은"; ItemRecipeName.text = "은 갑옷"; }
        }//갑옷 레시피
    }
}
