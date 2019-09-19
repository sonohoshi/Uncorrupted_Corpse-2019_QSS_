using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity
{
    public static float HP;
    void Start() 
    {
        base.Begin();
        HP = hp;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W)) gameObject.transform.Translate(new Vector3(0, 3, 0) * Time.deltaTime);
        if (Input.GetKey(KeyCode.S)) gameObject.transform.Translate(new Vector3(0, -3, 0) * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))gameObject.transform.Translate(new Vector3(3, 0, 0) * Time.deltaTime);
        if(Input.GetKey(KeyCode.A))gameObject.transform.Translate(new Vector3(-3, 0, 0) * Time.deltaTime);
    }

    protected void UseWeapon()
    {

    }

    protected void Inventory()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("FoodDepot"))
        {
            Food_Depot.interaction = true;
        }      
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("fdDoor"))
        {
            NowFood_Health.problem = 0;
            Food_Depot.interaction = false;
        }
    }
}
