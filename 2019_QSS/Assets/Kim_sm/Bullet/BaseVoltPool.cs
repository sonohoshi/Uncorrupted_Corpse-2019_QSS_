using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public static class BaseVoltPool
{
    private static List<BulletManager.BulletInfo> bullets = new List<BulletManager.BulletInfo>();
    private static readonly  BulletManager.BulletType type = BulletManager.BulletType.BaseVolt;
    private static readonly float LiveTime = 0.5f; // 대충 10미터라고 잡아보자.
    private static Transform BulletLocation;
    private static Transform GunRotation;
    private static Vector3 moveVector = new Vector3(0, 50, 0);

    private static readonly Vector3 addModifyAngle = new Vector3(0, 0, -90);

    private static IEnumerator MoveBullet()
    {
        while (true)
        {
            while (bullets.Count > 0)
            {
                for (int i = 0; i < bullets.Count; i++)
                {
                    if (bullets[i].LiveTime <= 0 || !bullets[i].Bullet.gameObject.activeSelf)
                    {
                        if (bullets[i].Bullet.gameObject.activeSelf)
                        {
                            bullets[i].Bullet.gameObject.SetActive(false);
                        }

                        ObjectPoolManager.objectQueues[type].Enqueue(bullets[i]);
                        bullets.RemoveAt(i);
                        i--;
                        continue;
                    }

                    bullets[i].Bullet.Translate(moveVector * Time.deltaTime);

                    bullets[i].LiveTime -= 0.01f;
                }
                yield return new WaitForSeconds(0.01f);
            }
            yield return new WaitForEndOfFrame();
        }
    }

    public static void StartCoroutine()
    {
        CoroutineManager.Instance.StartCoroutine(MoveBullet());
    }

    public static Transform PoolingBullet()
    {
        BulletManager.BulletInfo bulletInfo = ObjectPoolManager.Dequeue(type);
        bulletInfo.Bullet.position = BulletLocation.position;
        bulletInfo.Bullet.eulerAngles = GunRotation.eulerAngles + addModifyAngle;
        bulletInfo.LiveTime = LiveTime;
        bullets.Add(bulletInfo);
        return bulletInfo.Bullet;
    }
    
    public static void AddBullet()
    {
        float rand = -Random.Range(5, 14f);
        Vector3 vec = new Vector3(0, 0, rand);

        Debug.Log("집탄율 : " + rand);

        for (; vec.z <= -rand; vec.z += -rand / 2)
        {
            BulletManager.BulletInfo info = ObjectPoolManager.Dequeue(type);
            info.Bullet.position = BulletLocation.position;
            info.Bullet.eulerAngles = GunRotation.eulerAngles + addModifyAngle + vec;
            info.LiveTime = LiveTime;
            if (vec.z == 0)
            {
                info.Bullet.eulerAngles += new Vector3(0,0,Random.Range(-rand * 0.1f, rand * 0.1f));
            }
            bullets.Add(info);
        }
    }

    public static void Initalize(Transform bulletLocation, Transform gunRotation)
    {
        BulletLocation = bulletLocation;
        GunRotation = gunRotation;
    }

}
