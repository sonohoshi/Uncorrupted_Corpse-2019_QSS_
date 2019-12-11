using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeWeaponFlip : MonoBehaviour
{
    private Transform target;
    public FindZombie findZombie;
    public PlayerController PC;
    private Transform Parent;
    private bool facingRight;
    
    // Start is called before the first frame update
    void Awake()
    {
        Parent = transform.parent;
        facingRight = false;
    }

    // Update is called once per frame
    void Update()
    {
        Flip();
    }

    private void Flip()
    {
        Transform target = findZombie.FindClosestEnemy();
        if (target != null)
        {
            Vector3 usingFlip = Parent.position - target.position;
            if (usingFlip.x < 0 && facingRight || usingFlip.x > 0 && !facingRight)
            {
                facingRight = !facingRight;

                Vector3 theCharacterScale = Parent.localScale;
                Vector3 theWeaponScale = transform.localScale;
                theCharacterScale.x *= -1;
                theWeaponScale.x *= -1;

                transform.localScale = theWeaponScale;
                Parent.localScale = theCharacterScale;
            }
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

                transform.localScale = theWeaponScale;
                Parent.localScale = theCharacterScale;
            }
        }
    }
}
