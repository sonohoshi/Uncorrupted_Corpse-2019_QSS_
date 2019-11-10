using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class BulletManager
{
    public enum BulletType : int { Base = 0, Silver = 1, BaseVolt = 2, SilverVolt = 3 }
    public class BulletInfo
    {
        public Transform Bullet { get; set; }
        public BulletType ImageType { get; set; }
        public float LiveTime { get; set; }
    }

    public static string BulletTypeToPath(BulletType type)
    {
        switch (type)
        {
            case BulletType.Base: return @"BulletPrefabs/BaseBullet";
            case BulletType.Silver: return @"BulletPrefabs/SilverBullet";
            case BulletType.BaseVolt: return @"BulletPrefabs/BaseVolt";
            case BulletType.SilverVolt: return @"BulletPrefabs/SilverVolt";
        }

        throw new System.NullReferenceException();
    }
    
    public static float GetBulletDamage(BulletType type) // 태그로 관리 //기욱쿤 부탁해!!!
    {
        switch (type)
        {
            case BulletType.Base: return 0;
            case BulletType.Silver: return 0;
            case BulletType.BaseVolt: return 0;
            case BulletType.SilverVolt: return 0;
        }

        throw new System.NullReferenceException();
    }

}
