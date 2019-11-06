using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class TestZombie : Zombie
{
    private GameObject target;
    private float attack_delay = 0, frame_count = 0;

    // Start is called before the first frame update
    void Start()
    {
        target = SelectTarget();
        Begin(100, 0, 2, 10);
    }
    // Update is called once per frame
    void Update()
    {
        if (target == null || frame_count % 2 == 0) target = SelectTarget();
        Vector3 dir = target.transform.position - transform.position;
        Move(dir);
        frame_count += Time.deltaTime; 
        attack_delay += Time.deltaTime;
    }

    private void OnCollisionStay2D(Collision2D collision)
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
