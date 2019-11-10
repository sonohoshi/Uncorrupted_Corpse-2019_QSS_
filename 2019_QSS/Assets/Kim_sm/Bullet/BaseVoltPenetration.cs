using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseVoltPenetration : MonoBehaviour
{
    private float penetrationSize = 30;
    public static BaseVoltPenetration Instance { get; private set; }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            penetrationSize -= collision.attachedRigidbody.mass;

            if (penetrationSize <= 0)
            {
                gameObject.SetActive(false);
            }
        }
    }

    private void Awake()
    {
        Instance = this;
    }

    public void SetPenetrationSize()
    {
        penetrationSize = 30;
    }

}
