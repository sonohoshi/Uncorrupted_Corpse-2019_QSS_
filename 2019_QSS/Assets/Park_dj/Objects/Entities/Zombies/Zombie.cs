using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Zombie : Entity
{
    protected float Structure_Attack;

    public enum ZombieType
    {
       CommonZombie,
       ZombieDog,
       MegalZombie,
       BloodZombie,
       PoliceZombie
    }

    public enum BossZombie
    {
        BigZzangZzangSanZombie
    }

    public void Move(Vector3 dir)
    {
        transform.Translate(dir.normalized * speed * Time.deltaTime);
        GetComponent<SpriteRenderer>().flipX = dir.x < 0;
    }
    public GameObject SelectTarget()
    {
        //target: 반환할 타깃; list: 타깃 가능한 오브젝트들 목록
        float prePriority = -1000.0f;
        GameObject target;
        GameObject[] list = GameObject.FindGameObjectsWithTag("Structures");
        list = list.Concat(GameObject.FindGameObjectsWithTag("FoodDepot")).ToArray();
        list = list.Concat(GameObject.FindGameObjectsWithTag("Player")).ToArray();
        target = list[0];


        Vector3 dir;
        //list의 각 오브젝트 대해, (기본 어그로 수치) - (거리 당 어그로 수치) * (거리) 계산하여
        //최적의 타깃 선택하여 반환
        foreach (GameObject obj in list)
        {
            // 타깃과의 거리
            dir = (target.transform.position - transform.position);

            //비교할 대상과의 거리
            float targetdist = dir.magnitude;
            float cmpdist = (obj.transform.position - transform.position).magnitude;


            //플레이어? 구조물?
            if (obj.GetComponent<Player>())
            {
                if (obj.GetComponent<Player>().GetPriorityPoints(cmpdist) > prePriority )
                {
                    target = obj;
                    prePriority = target.GetComponent<Player>().GetPriorityPoints(cmpdist);
                }
            }
            else if (obj.GetComponent<Structures>().GetPriorityPoints(cmpdist) > prePriority )
            {
                target = obj;
                prePriority = target.GetComponent<Structures>().GetPriorityPoints(cmpdist);
            }
        }

        return target;
    }
}
