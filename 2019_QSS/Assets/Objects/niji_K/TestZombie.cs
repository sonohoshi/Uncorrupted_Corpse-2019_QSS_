using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class TestZombie : Zombie
{
    private GameObject target;
    private float attack_delay = 0, time_count = 0;

    // Start is called before the first frame update
    void Start()
    {
        target = SelectTarget();
        Begin(100, 0, 2, 10);
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 dir;
        if (target == null || time_count >= 2){
            target = SelectTarget();
            time_count = 0;
        }
        dir = target.transform.position - transform.position;
        Move(dir);
        time_count += Time.deltaTime; 
        attack_delay += Time.deltaTime;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (attack_delay >= 0.5)
        {
            if (collision.gameObject.GetComponent<Structures>())
                collision.gameObject.GetComponent<Structures>().Attacked(Power);
            else if (collision.gameObject.GetComponent<Player>())
                collision.gameObject.GetComponent<Player>().Attacked(Power);
            attack_delay = 0;
        }
    }
}
