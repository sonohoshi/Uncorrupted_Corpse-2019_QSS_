using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity
{
    private float BasePoint;
    private float DistWeight;
    void Start() 
    {
        Begin(100, 5, 5, 10, 30, 1);
    }
    protected void Begin(float hp, float dp, float sp, float pow, float bp, float dist)
    {
        HP = hp;
        DP = dp;
        speed = sp;
        Power = pow;
        BasePoint = bp;
        DistWeight = dist;
        GetComponent<Rigidbody2D>().mass = DP;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W)) gameObject.transform.Translate(new Vector3(0, 3, 0) * Time.deltaTime);
        if (Input.GetKey(KeyCode.S)) gameObject.transform.Translate(new Vector3(0, -3, 0) * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))gameObject.transform.Translate(new Vector3(3, 0, 0) * Time.deltaTime);
        if(Input.GetKey(KeyCode.A))gameObject.transform.Translate(new Vector3(-3, 0, 0) * Time.deltaTime);
    }

    public float GetPriorityPoints(float distance)
    {
        return BasePoint - (distance * DistWeight);
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

    public void Attacked(float atk)
    {
        HP -= atk - DP; Debug.Log(HP);
        if (HP <= 0) { Destroy(gameObject); }
    }
}
