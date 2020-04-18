using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class TestZombie : Zombie
{
    private GameObject target;
    private float attack_delay = 0, time_count = 0;
    private Vector3 dir;
    private static readonly int playerLayer = (1 << 9);

    // Start is called before the first frame update
    void Start()
    {
        target = SelectTarget();
        Begin(100, 0, 2, 10);
        StartCoroutine(zombieDirection());
    }
    // Update is called once per frame
    void Update()
    {
        if (target == null || time_count >= 2){
            target = SelectTarget();
            time_count = 0;
        }
        var raycastHit2D = Physics2D.Raycast(transform.position, dir, 0.65f, playerLayer);
        if(raycastHit2D.collider == null)
            Move(dir);
        time_count += Time.deltaTime;
        attack_delay += Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("BulletOrVolt"))
        {
            if (collision.gameObject.GetComponent<BulletPenetration>())
                gameObject.GetComponent<Zombie>().Attacked(collision.gameObject.GetComponent<BulletPenetration>().GetBulletDamage());
            if (collision.gameObject.GetComponent<BaseVoltPenetration>() || collision.gameObject.GetComponent<SilverVoltPenetration>())
                gameObject.GetComponent<Zombie>().Attacked(collision.gameObject.GetComponent<BaseVoltPenetration>().GetBulletDamage());
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (attack_delay >= 0.5)
        {
            if (collision.gameObject.GetComponent<Structures>())
                collision.gameObject.GetComponent<Structures>().Attacked(Power);
            else if (collision.gameObject.GetComponent<Food_Depot>())
                collision.gameObject.GetComponent<Food_Depot>().Attacked(Power);
            else if (collision.gameObject.GetComponent<Player>())
                collision.gameObject.GetComponent<Player>().Attacked(Power);
            attack_delay = 0;
        }
    }

    IEnumerator zombieDirection() 
    {
        while (true)
        {
            dir = target.transform.position - transform.position;
            GameObject obj = Physics2D.Raycast(transform.position, dir, Mathf.Infinity, 1 << 12).transform.gameObject;
            Debug.Log(obj);
            if (obj != target)
            {
                float angle = Random.Range(0, 2 * Mathf.PI);
                dir = new Vector3(Mathf.Sin(angle), Mathf.Cos(angle));
                yield return new WaitForSeconds(2f);
            }
            else yield return new WaitForSeconds(.1f);
        }
    }
}
