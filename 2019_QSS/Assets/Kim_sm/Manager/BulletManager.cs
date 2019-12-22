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
}
