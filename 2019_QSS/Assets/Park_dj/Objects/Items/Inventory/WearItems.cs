using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WearItems : MonoBehaviour
{
    public static int WearRangedWeapon = 0;
    //무기번호 : 1번 배트, 2번 강화 배트, 3번 광선검
    public static int WearCloseRangeWeapon = 0;
    //무기번호 : 4번 쇠뇌 5번 강화 쇠뇌, 6번 붕괴 쇠뇌, 7번 돌격 소총, 8번 레이저 돌격 소총, 9번 권총, 10번 레이저 권총, 11번 산탄총, 12번 붕괴 산탄총 
    public static int WearOneTimeWeapon = 0;
    //무기번호 : 1번 수류탄, 2번 파편 지뢰, 3번 화염병
    public static int WearArmor = 0;
    //무기번호 : 1번 옷, 2번 갑옷, 3번 은 갑옷


    public static int[] WearItem()
    {
        int[] EquippedItems = { WearCloseRangeWeapon, WearRangedWeapon,  WearOneTimeWeapon, WearArmor};
        return EquippedItems;
    }

    private void Update()
    {       
        if(WearCloseRangeWeapon != 0)
        {
            if (WearCloseRangeWeapon == 1)
            {
                if (Bat.cnt == 0)
                    WearCloseRangeWeapon = 0;
            }
            else if (WearCloseRangeWeapon == 2)
            {
                if (ReinforcedBat.cnt == 0)
                    WearCloseRangeWeapon = 0;
            }
            else if (WearCloseRangeWeapon == 3)
            {
                if (Lightsaber.cnt == 0)
                    WearCloseRangeWeapon = 0;
            }
        }//근접 공격 무기 존재 여부 확인

        if (WearRangedWeapon != 0)
        {
            if (WearRangedWeapon == 4)
            {
                if (Crossbow.cnt == 0)
                    WearRangedWeapon = 0;
            }
            else if (WearRangedWeapon == 5)
            {
                if (ReinforcedCrossbow.cnt == 0)
                    WearRangedWeapon = 0;
            }
            else if (WearRangedWeapon == 6)
            {
                if (CollapseCrossbow.cnt == 0)
                    WearRangedWeapon = 0;
            }
            else if (WearRangedWeapon == 7)
            {
                if (AssaultRifle.cnt == 0)
                    WearRangedWeapon = 0;
            }
            else if (WearRangedWeapon == 8)
            {
                if (LaserAssaultRifle.cnt == 0)
                    WearRangedWeapon = 0;
            }
            else if (WearRangedWeapon == 9)
            {
                if (Handgun.cnt == 0)
                    WearRangedWeapon = 0;
            }
            else if (WearRangedWeapon == 10)
            {
                if (LaserHandGun.cnt == 0)
                    WearRangedWeapon = 0;
            }
            else if (WearRangedWeapon == 11)
            {
                if (Shotgun.cnt == 0)
                    WearRangedWeapon = 0;
            }
            else if (WearRangedWeapon == 12)
            {
                if (CollapseShotGun.cnt == 0)
                    WearRangedWeapon = 0;
            }
        }//원거리 공격 무기 존재 여부 확인

        if(WearOneTimeWeapon != 0)
        {
            if (WearOneTimeWeapon == 1)
            {
                if (Grenade.cnt == 0)
                    WearOneTimeWeapon = 0;
            }
            else if (WearOneTimeWeapon == 2)
            {
                if (FragmentMine.cnt == 0)
                    WearOneTimeWeapon = 0;
            }
            else if (WearOneTimeWeapon == 3)
            {
                if (FlameBottle.cnt == 3)
                    WearOneTimeWeapon = 0;
            }
        }//일회성 공격 무기 존재 여부 확인

        if(WearArmor != 0)
        {
            if (WearArmor == 1)
            {
                if (Clothes.cnt == 0)
                    WearArmor = 0;
            }
            else if (WearArmor == 2)
            {
                if (Armor.cnt == 0)
                    WearArmor = 0;
            }
            else if (WearArmor == 3)
            {
                if (SilverArmor.cnt == 0)
                    WearArmor = 0;
            }
        }//갑옷 존재 여부 확인    
    }
}
