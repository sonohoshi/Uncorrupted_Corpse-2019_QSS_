using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponRotateAndFlip : MonoBehaviour
{
    private Transform target;
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
            Vector3 usingFlip = Parent.position - target.position;

            if (usingFlip.x < 0 && facingRight || usingFlip.x > 0 && !facingRight)
            {
                facingRight = !facingRight;

                Vector3 theCharacterScale = Parent.localScale;
                Vector3 theWeaponScale = transform.localScale;
                theCharacterScale.x *= -1;
                theWeaponScale.x *= -1;
                theWeaponScale.y *= -1;

                transform.localScale = theWeaponScale;
                Parent.localScale = theCharacterScale;
            }

            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        }else
        {
            Vector3 nulDir = PC.PoolInput();
            if (nulDir.x < 0 && !facingRight || nulDir.x >= 0 && facingRight)
            {
                facingRight = !facingRight;

                Vector3 theCharacterScale = Parent.localScale;
                Vector3 theWeaponScale = transform.localScale;
                theCharacterScale.x *= -1;
                theWeaponScale.x *= -1;
                theWeaponScale.y *= -1;

                transform.localScale = theWeaponScale;
                Parent.localScale = theCharacterScale;
            }
            float angle = Mathf.Atan2(nulDir.y, nulDir.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }
}
