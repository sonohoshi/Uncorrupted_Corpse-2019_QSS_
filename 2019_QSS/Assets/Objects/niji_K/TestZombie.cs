using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class TestZombie : Zombie
{
    private GameObject target;
    private int attack_delay = 0, frame_cnt = 0;

    // Start is called before the first frame update
    void Start()
    {
        target = SelectTarget();
        speed = 3;
        Power = 10;
    }
    // Update is called once per frame
    void Update()
    {
        if (target == null || frame_cnt % 120 == 0) target = SelectTarget();
        Vector3 dir = target.transform.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime);
        frame_cnt++;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (attack_delay <= 0)
        {
            if (collision.gameObject.GetComponent<Structures>())
                collision.gameObject.GetComponent<Structures>().Attacked(Power);
            else{
                //collision.gameObject.GetComponent<Player>().Attacked(Power);          TODO: 구현 필요
            }
        }
    }
}
