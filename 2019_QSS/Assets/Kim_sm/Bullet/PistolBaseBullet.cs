using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public static class PistolBaseBullet
{
    private static List<BulletManager.BulletInfo> bullets = new List<BulletManager.BulletInfo>();
    public readonly static  BulletManager.BulletType type = BulletManager.BulletType.Base;
    private static readonly float LiveTime = 1f; // 대충 10미터라고 잡아보자.
    public static Transform BulletLocation;
    public static Transform GunRotation;
    private static Vector3 moveVector = new Vector3(0, 50, 0);
    private static int dirBullet = 15;

    private static bool reloadSwitch = false;
    private static bool pistolDelay = false;

    private static readonly Vector3 addModifyAngle = new Vector3(0, 0, -90);

    private static IEnumerator MoveBullet()
    {
        while (true)
        {
            while (bullets.Count > 0)
            {
                //Debug.Log("MoveBullet looping");
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
            Attack.SetReloadTime(1f);
            yield return new WaitForSeconds(1f);
            reloadSwitch = false;
            dirBullet = 15;
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
    
    public static IEnumerator PistolDelayManage()
    {
        if (!pistolDelay)
        {
            FirePistolBullet();
            pistolDelay = true;
            yield return new WaitForSeconds(0.2f);
            pistolDelay = false;
        }
    }
    public static void StartPistolDelayCoroutine()
    {
        CoroutineManager.Instance.StartCoroutine(PistolDelayManage());
    }

    public static void FirePistolBullet()
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
    }

    public static void Initalize(Transform bulletLocation, Transform gunRotation)
    {
        BulletLocation = bulletLocation;
        GunRotation = gunRotation;
    }

}
