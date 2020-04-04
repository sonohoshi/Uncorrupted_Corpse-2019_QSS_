using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretRotate : MonoBehaviour
{
    private Transform target;
    private FindZombie findZombie;
    
    // Start is called before the first frame update
    void Start()
    {
        findZombie = this.gameObject.GetComponent<FindZombie>();
    }

    // Update is called once per frame
    void Update()
    {
        LookEnemy();
    }

    void LookEnemy()
    {
        Transform target = findZombie.FindClosestEnemy();
        
        if (target != null)
        {
            Vector3 dir = target.position - this.transform.position; // 부모 오브젝트 받아와서 좀비랑 포지션 계산함

            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }
}
