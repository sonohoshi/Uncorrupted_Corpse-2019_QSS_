using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class ObjectPoolManager
{
    public static Dictionary<BulletManager.BulletType, Queue<BulletManager.BulletInfo>> objectQueues = Enum.GetValues(typeof(BulletManager.BulletType)).OfType<BulletManager.BulletType>()
                                                                             .ToDictionary(x => x, x => new Queue<BulletManager.BulletInfo>());
    
    public static void Enqueue(BulletManager.BulletType type, BulletManager.BulletInfo info)
    {
        objectQueues[type].Enqueue(info);
    }

    public static BulletManager.BulletInfo Dequeue(BulletManager.BulletType type)
    {
        BulletManager.BulletInfo info;

        if (objectQueues[type].Count > 0)
        {
            info = objectQueues[type].Dequeue();
            info.Bullet.gameObject.SetActive(true);
        }
        else
        {
            info = new BulletManager.BulletInfo();
            info.Bullet = MonoBehaviour.Instantiate<Transform>(Resources.Load<Transform>(BulletManager.BulletTypeToPath(type)));
            info.ImageType = type;
        }

        return info;
    }
    /*
    public bool PushToPool(string itemName, GameObject item, Transform parent = null)
    {
        BulletManager pool = GetPoolItem(itemName);
        if (pool == null)
            return false;

        pool.PushToPool(item, parent == null ? transform : parent);
        return true;
    }
    public GameObject PopFromPool(string itemName, Transform parent = null)
    {
        BulletManager pool = GetPoolItem(itemName);
        if (pool == null)
            return null;

        return pool.PopFromPool(parent);
    }
    BulletManager GetPoolItem(string itemName)
    {
        for (int ix = 0; ix < objectQueues.Count; ++ix)
        {
            if (objectQueues[ix].poolItemName.Equals(itemName))
                return objectQueues[ix];
        }

        Debug.LogWarning("There's no matched pool list.");
        return null;
    }
    */
}
