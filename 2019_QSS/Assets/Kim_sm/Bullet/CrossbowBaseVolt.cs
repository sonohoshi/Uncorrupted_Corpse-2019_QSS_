﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CrosbowBaseBullet
{
    private static List<BulletManager.BulletInfo> bullets = new List<BulletManager.BulletInfo>();
    public readonly static BulletManager.BulletType type = BulletManager.BulletType.BaseVolt;
    private static readonly float LiveTime = 1.5f; // 대충 15미터라고 잡아보자.
    public static Transform BulletLocation;
    public static Transform GunRotation;
    private static Vector3 moveVector = new Vector3(0, 50, 0);
    private static int dirBullet = 1;

    private static bool reloadSwitch = false;
    private static bool crosbowDelay = false;

    private static readonly Vector3 addModifyAngle = new Vector3(0, 0, -90);

    private static IEnumerator MoveBullet()
    {
        while (true)
        {
            while (bullets.Count > 0)
            {
                // Debug.Log("MoveBullet looping");
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
    private static IEnumerator ReloadBullet()
    {
        if (dirBullet <= 0 && !reloadSwitch)
        {
            Debug.Log("Reloading");
            reloadSwitch = true;
            yield return new WaitForSeconds(0.5f);
            reloadSwitch = false;
            dirBullet = 1;
            Debug.Log("Reload Complete");
        }
        else if (dirBullet <= 0 && reloadSwitch) // 이미 재장전을 하고 있을 때는 재장전 중을 알려줌
        {
            Debug.Log("Already reloading");
        }
    }

    public static void StartCoroutine()
    {
        CoroutineManager.Instance.StartCoroutine(MoveBullet());
    }

    public static IEnumerator CrosbowDelayManage()
    {
        if (!crosbowDelay)
        {
            FireCrosbowBullet();
            crosbowDelay = true;
            yield return new WaitForSeconds(0.2f);
            crosbowDelay = false;
        }
    }
    public static void StartCrosbowDelayCoroutine()
    {
        CoroutineManager.Instance.StartCoroutine(CrosbowDelayManage());
    }

    public static void FireCrosbowBullet()
    {
        if (dirBullet > 0) // 현재 총알이 남아있을 경우
        {
            BulletManager.BulletInfo bulletInfo = ObjectPoolManager.Dequeue(type);
            bulletInfo.Bullet.position = BulletLocation.position;
            bulletInfo.Bullet.eulerAngles = GunRotation.eulerAngles + addModifyAngle;
            bulletInfo.LiveTime = LiveTime;
            bullets.Add(bulletInfo);

            dirBullet--;
            Debug.Log(dirBullet);
        }
        else // 아니라면 재장전 코루틴을 부른다
        {
            CoroutineManager.Instance.StartCoroutine(ReloadBullet());
        }

        BaseVoltPenetration.Instance.SetPenetrationSize();
    }
    public static void Initalize(Transform bulletLocation, Transform gunRotation)
    {
        BulletLocation = bulletLocation;
        GunRotation = gunRotation;
    }
    
}
