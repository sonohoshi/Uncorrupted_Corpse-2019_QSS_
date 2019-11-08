using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodPool : MonoBehaviour
{
    float decay_time = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Color tmp = GetComponent<SpriteRenderer>().color;
        GetComponent<SpriteRenderer>().color = new Vector4(tmp.r, tmp.g, tmp.b, decay_time / 10);
        if (decay_time <= 0) Destroy(gameObject);
        decay_time -= Time.deltaTime;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {

        if (collision.gameObject.GetComponent<Structures>())
            collision.gameObject.GetComponent<Structures>().Attacked(0.1f);
        else if (collision.gameObject.GetComponent<Player>())
            collision.gameObject.GetComponent<Player>().Attacked(0.1f);
    }
}
