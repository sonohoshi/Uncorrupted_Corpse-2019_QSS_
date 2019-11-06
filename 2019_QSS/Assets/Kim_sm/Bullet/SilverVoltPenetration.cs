using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SilverVoltPenetration : MonoBehaviour
{
    private float penetrationSize = 50;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            if (penetrationSize <= 0)
            {
                gameObject.SetActive(false);
            }
            else if (penetrationSize > 0)
            {
                penetrationSize -= collision.attachedRigidbody.mass; // mass == 방어도
            }
        }
    }
}
