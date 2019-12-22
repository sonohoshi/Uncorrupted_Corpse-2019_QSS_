using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

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
            //info.Bullet = MonoBehaviour.Instantiate<Transform>(Resources.Load<Transform>(BulletManager.BulletTypeToPath(type)));
            info.Bullet = PhotonNetwork.Instantiate(Resources.Load<GameObject>(BulletManager.BulletTypeToPath(type)).name, Vector3.forward,
                Quaternion.identity).transform;
            info.ImageType = type;
        }

        return info;
    }
}
