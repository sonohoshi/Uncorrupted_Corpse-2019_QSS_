using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ShotgunBaseBullet
{
    private static List<BulletManager.BulletInfo> bullets = new List<BulletManager.BulletInfo>();
    public readonly static BulletManager.BulletType type = BulletManager.BulletType.Base;
    private static readonly float LiveTime = 3f;
    public static Transform BulletTransform;
    public static Transform GunRotation;
    private static Vector3 moveVector = new Vector3(0, 15, 0);
    private static int dirBullet = 15;

    private static bool reloadSwitch = false;
    private static bool shotgunDelay = false;

    private static readonly Vector3 addAngle = new Vector3(0, 0, -90);
    private static readonly float minAngle = -6;

    private static IEnumerator MoveBullet()
    {
        while (true)
        {
            while (bullets.Count > 0)
            {
                // Debug.Log("MoveBullet looping");
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

                    bullets[i].Bullet.Translate(moveVector * Time.deltaTime * Random.Range(0.8f, 1.2f));

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
            yield return new WaitForSeconds(5f);
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

    public static IEnumerator ShotgunDelayManage()
    {
        if (!shotgunDelay)
        {
            FireshotgunBullet();
            shotgunDelay = true;
            yield return new WaitForSeconds(0.2f);
            shotgunDelay = false;
        }
    }
    public static void StartshotgunDelayCoroutine()
    {
        CoroutineManager.Instance.StartCoroutine(ShotgunDelayManage());
    }

    private static void AddBullet()
    {
        float rand = -Random.Range(5, 14f);
        Vector3 vec = new Vector3(0, 0, rand);

        Debug.Log("집탄율 : " + rand);

        for (; vec.z <= -rand; vec.z += -rand / 2)
        {
            BulletManager.BulletInfo info = ObjectPoolManager.Dequeue(type);
            info.Bullet.position = BulletTransform.position;
            info.Bullet.eulerAngles = GunRotation.eulerAngles + addAngle + vec;
            info.LiveTime = LiveTime;
            if (vec.z == 0)
            {
                info.Bullet.eulerAngles += new Vector3(0,0,Random.Range(-rand * 0.1f, rand * 0.1f));
            }
            bullets.Add(info);
        }
    }

    public static void FireshotgunBullet()
    {
        if (/*dirBullet > 0*/ true) // 현재 총알이 남아있을 경우
        {
            /*
            BulletManager.BulletInfo bulletInfo = ObjectPoolManager.Dequeue(type);
            bulletInfo.Bullet.position = BulletTransform.position;
            bulletInfo.Bullet.eulerAngles = GunRotation.eulerAngles;
            bulletInfo.LiveTime = LiveTime;
            bullets.Add(bulletInfo);
            */
            AddBullet();
            dirBullet--;
            Debug.Log(dirBullet); // 살려줘 씨발
        }
        else // 아니라면 재장전 코루틴을 부른다
        {
            CoroutineManager.Instance.StartCoroutine(ReloadBullet());
        }
    }

    public static void Initalize(Transform bulletLocation, Transform gunRotation)
    {
        BulletTransform = bulletLocation;
        GunRotation = gunRotation;
    }

}
