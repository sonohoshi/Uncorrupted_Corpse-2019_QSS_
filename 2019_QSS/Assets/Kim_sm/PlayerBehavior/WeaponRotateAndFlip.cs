using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponRotateAndFlip : MonoBehaviour
{
    private Transform target;
    private FindZombie findZombie;
    private PlayerController PC;
    private Transform parent;
    private bool facingRight;
    
    // Start is called before the first frame update
    void Start()
    {
        parent = transform.parent;
        facingRight = false;
        findZombie = parent.GetComponent<FindZombie>();
        PC = parent.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, Vector2.right, Color.cyan);
        LookZombieAndFlip();
    }

    void LookZombieAndFlip()
    {
        Transform target = findZombie.FindClosestEnemy();
        if (target != null)
        {
            Vector3 dir = target.position - parent.position; // 부모 오브젝트 받아와서 좀비랑 포지션 계산함
            Vector3 usingFlip = parent.position - target.position;

            if (usingFlip.x < 0 && facingRight || usingFlip.x > 0 && !facingRight)
            {
                facingRight = !facingRight;

                Vector3 theCharacterScale = parent.localScale;
                Vector3 theWeaponScale = transform.localScale;
                theCharacterScale.x *= -1;
                theWeaponScale.x *= -1;
                theWeaponScale.y *= -1;

                transform.localScale = theWeaponScale;
                parent.localScale = theCharacterScale;
            }

            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
        else
        {
            Vector3 nulDir = PC.PoolInput();
            if (nulDir.x < 0 && !facingRight || nulDir.x >= 0 && facingRight)
            {
                facingRight = !facingRight;

                Vector3 theCharacterScale = parent.localScale;
                Vector3 theWeaponScale = transform.localScale;
                theCharacterScale.x *= -1;
                theWeaponScale.x *= -1;
                theWeaponScale.y *= -1;

                transform.localScale = theWeaponScale;
                parent.localScale = theCharacterScale;
            }
            float angle = Mathf.Atan2(nulDir.y, nulDir.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }
}
