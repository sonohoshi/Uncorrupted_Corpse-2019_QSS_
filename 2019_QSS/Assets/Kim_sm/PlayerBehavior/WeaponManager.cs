using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    public Transform target;
    public FindZombie findZombie;
    private Transform Parent;
    // Start is called before the first frame update
    void Start()
    {
        Parent = transform.parent;
    }

    // Update is called once per frame
    void Update()
    {
        LookZombieAndFlip();
    }

    void LookZombieAndFlip()
    {
        Transform target = findZombie.FindClosestEnemy();
        Vector3 dir = target.position - Parent.position; // 부모 오브젝트 받아와서 좀비랑 포지션 계산함
        Vector3 UsingFlip = Parent.position - target.position;
        
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
