using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodZombie : Zombie
{
    public GameObject blood_pool;
    private GameObject target;
    private float attack_delay = 4, frame_count = 0;

    // Start is called before the first frame update
    void Start()
    {
        target = SelectTarget(); 
        Begin(80, 0, 2, 15);
    }
    // Update is called once per frame
    void Update()
    {
        if (target == null || frame_count % 120 == 0) target = SelectTarget();
        Vector3 dir = target.transform.position - transform.position;
        if(attack_delay <= 4) Move(dir);

        attack_delay -= Time.deltaTime;

        if (attack_delay <= 0) {
            Instantiate(blood_pool, transform.position + new Vector3((dir.y > 0 ? -0.8f : 0.8f), 0.2f, 0), new Quaternion(0, 0, 0, 0));
            attack_delay = 5;
        }
    }
}
