using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PistolBaseBullet
{
    private static List<BulletManager.BulletInfo> bullets = new List<BulletManager.BulletInfo>();
    public readonly static  BulletManager.BulletType type = BulletManager.BulletType.Base;
    private static readonly float LiveTime = 3f;
    public static Transform BulletLocation;
    public static Transform GunRotation;
    private static Vector3 moveVector = new Vector3(0, 10, 0);

    private static readonly Vector3 addAngle = new Vector3(0, 0, -90);

    private static IEnumerator MoveBullet()
    {
        while (true)
        {
            while (bullets.Count > 0)
            {
                Debug.Log("MoveBullet looping");
                for (int i = 0; i < bullets.Count; i++)
                {
                    if (bullets[i].LiveTime <= 0)
                    {
                        bullets[i].Bullet.gameObject.SetActive(false);
                        ObjectPoolManager.objectQueues[type].Enqueue(bullets[i]);
                        bullets.RemoveAt(i);
                        i--;
                        continue;
                    }

                    bullets[i].Bullet.Translate(moveVector * Time.deltaTime);

                    bullets[i].LiveTime -= 0.1f;
                }
                yield return new WaitForSeconds(0.1f);
            }

            yield return new WaitForEndOfFrame();
        }
    }

    public static void StartCoroutine()
    {
        CoroutineManager.Instance.StartCoroutine(MoveBullet());
    }
    
    public static void ShotBullet()
    {
        BulletManager.BulletInfo bulletInfo = ObjectPoolManager.Dequeue(BulletManager.BulletType.Base);
        bulletInfo.Bullet.position = BulletLocation.position;
        bulletInfo.Bullet.eulerAngles = GunRotation.eulerAngles + addAngle;
        bulletInfo.LiveTime = LiveTime;
        bullets.Add(bulletInfo);
    }

    public static void Initalize(Transform bulletLocation, Transform gunRotation)
    {
        BulletLocation = bulletLocation;
        GunRotation = gunRotation;
    }
}
