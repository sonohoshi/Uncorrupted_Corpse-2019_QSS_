using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPenetration : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
            gameObject.SetActive(false);
    }
}
