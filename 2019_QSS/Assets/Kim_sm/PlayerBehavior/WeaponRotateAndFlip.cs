using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponRotateAndFlip : MonoBehaviour
{
    public Transform target;
    public FindZombie findZombie;
    public PlayerController PC;
    private Transform Parent;
    private bool facingRight;
    // Start is called before the first frame update
    void Start()
    {
        Parent = transform.parent;
        facingRight = false;
    }

    // Update is called once per frame
    void Update()
    {
        LookZombieAndFlip();
    }

    void LookZombieAndFlip()
    {
        Transform target = findZombie.FindClosestEnemy();
        if (target != null)
        {
            Vector3 dir = target.position - Parent.position; // 부모 오브젝트 받아와서 좀비랑 포지션 계산함
            Vector3 UsingFlip = Parent.position - target.position;

            if (UsingFlip.x < 0 && facingRight || UsingFlip.x > 0 && !facingRight)
            {
                facingRight = !facingRight;

                Vector3 theChaeracterScale = Parent.localScale;
                Vector3 theWeaponScalse = transform.localScale;
                theChaeracterScale.x *= -1;
                theWeaponScalse.x *= -1;
                theWeaponScalse.y *= -1;

                transform.localScale = theWeaponScalse;
                Parent.localScale = theChaeracterScale;
            }

            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        }else
        {
            transform.rotation = Quaternion.AngleAxis(1, PC.PoolInput());
        }
    }
}
